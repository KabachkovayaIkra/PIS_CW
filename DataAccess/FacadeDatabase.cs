using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class FacadeDatabase :
        IFacadeLogin, IFacadeRegistration,
        IFacadeEmployer, IFacadeEmployee, IFacadeManager
    {
        private readonly DataContext db;

        public FacadeDatabase()
        {
            db = new DataContext();
        }

        // ===== AUTH =====
        public bool AuthManager(string login, string password)
            => db.Managers.Any(m => m.Login == login && m.HashPassword == password);

        public bool AuthEmployer(string login, string password)
            => db.Employers.Any(e => e.Login == login && e.HashPassword == password);

        public bool AuthEmployee(string login, string password)
            => db.Employees.Any(e => e.Login == login && e.HashPassword == password);

        // ===== REGISTRATION =====
        public int RegisterManager(string login, string password, string name)
        {
            var m = new Manager { Login = login, HashPassword = password, FullName = name };
            db.Managers.Add(m);
            db.SaveChanges();
            return m.ManagerId;
        }

        public int RegisterEmployer(string login, string password, string orgName)
        {
            var e = new Employer { Login = login, HashPassword = password, OrganizationName = orgName };
            db.Employers.Add(e);
            db.SaveChanges();
            return e.EmployerId;
        }

        public int RegisterEmployee(string login, string password, string fn, string ln, string mn)
        {
            var e = new Employee
            {
                Login = login,
                HashPassword = password,
                FirstName = fn,
                LastName = ln,
                MiddleName = mn
            };
            db.Employees.Add(e);
            db.SaveChanges();
            return e.EmployeeId;
        }

        // ===== EMPLOYER OPERATIONS =====
        public int CreateVacancy(int empId, string prof, int tbi, double sal, string info)
        {
            var v = new Vacancy
            {
                EmployerId = empId,
                Profession = prof,
                Salary = sal,
                TypeOfBusinessId = tbi,
                VacancyInfo = info,
                VacancyStatus = "Open"
            };
            db.Vacancies.Add(v);
            db.SaveChanges();
            return v.VacancyId;
        }

        public List<Vacancy> ListVacancies(int employerId)
        {
            return db.Vacancies.Include(v => v.TypeOfBusiness)
                               .Where(v => v.EmployerId == employerId)
                               .ToList();
        }

        public List<TypeOfBusiness> ListBusinessTypes()
        {
            return db.TypesOfBusiness.ToList();
        }

        // ===== EMPLOYEE OPERATIONS =====
        public List<Vacancy> SearchVacancies(string filter)
        {
            IQueryable<Vacancy> q = db.Vacancies.Include(v => v.Employer).Include(v => v.TypeOfBusiness);
            if (!string.IsNullOrWhiteSpace(filter))
                q = q.Where(v => v.Profession.Contains(filter) || v.VacancyInfo.Contains(filter));
            return q.ToList();
        }

        public bool ApplyForVacancy(int empId, int vacId)
        {
            if (db.Deals.Any(d => d.EmployeeId == empId && d.VacancyId == vacId))
                return false;

            var vac = db.Vacancies.Find(vacId);
            if (vac == null) return false;

            var emp = db.Employees.Find(empId);
            if (emp == null) return false;

            var deal = new Deal
            {
                EmployeeId = empId,
                EmployerId = vac.EmployerId,
                VacancyId = vacId,
                ManagerId = 0,
                DateOfSigning = null
            };

            db.Deals.Add(deal);
            db.SaveChanges();
            return true;
        }

        public List<Deal> ListDealsForEmployee(int empId)
        {
            return db.Deals
                     .Include(d => d.Vacancy)
                     .Include(d => d.Employer)
                     .Include(d => d.Manager)
                     .Where(d => d.EmployeeId == empId)
                     .ToList();
        }

        // ===== MANAGER OPERATIONS =====
        public List<Deal> ListDeals()
        {
            return db.Deals
                     .Include(d => d.Vacancy)
                     .Include(d => d.Employer)
                     .Include(d => d.Employee)
                     .Include(d => d.Manager)
                     .ToList();
        }

        public bool SignDeal(int dealId, DateTime dateOfSign)
        {
            var d = db.Deals.Find(dealId);
            if (d == null || d.ManagerId != 0) return false;

            // пример выбора менеджера - берём первого
            var mgr = db.Managers.FirstOrDefault();
            if (mgr == null) return false;

            d.ManagerId = mgr.ManagerId;
            d.DateOfSigning = dateOfSign;
            db.SaveChanges();
            return true;
        }

        public void UpdateVacancy(int vacancyId, string info, string status)
        {
            var v = db.Vacancies.Find(vacancyId);
            if (v == null) return;
            v.VacancyInfo = info;
            v.VacancyStatus = status;
            db.SaveChanges();
        }
    }
}
