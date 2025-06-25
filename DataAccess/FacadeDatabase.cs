using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using DataAccess.Models;
using static System.Collections.Specialized.BitVector32;

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

        public int RegisterEmployer(string login, string password, string orgName)
        {
            var e = new Employer { Login = login, HashPassword = password};
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
        public int CreateVacancy(int empId, string prof, int tbi, decimal sal, string info)
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
            return db.Vacancies.Include(v => v.TypeOfBusinessId)
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
            IQueryable<Vacancy> q = db.Vacancies.Include(v => v.EmployerId).Include(v => v.TypeOfBusinessId);
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
                DateOfSigning = DateTime.Now
            };

            db.Deals.Add(deal);
            db.SaveChanges();
            return true;
        }

        public List<Deal> ListDealsForEmployee(int empId)
        {
            return db.Deals
                     .Include(d => d.VacancyId)
                     .Include(d => d.EmployerId)
                     .Where(d => d.EmployeeId == empId)
                     .ToList();
        }

        // ===== MANAGER OPERATIONS =====
        public List<Deal> ListDeals()
        {
            return db.Deals
                     .Include(d => d.VacancyId)
                     .Include(d => d.EmployerId)
                     .Include(d => d.EmployeeId)
                     .ToList();
        }

        public bool SignDeal(int dealId, DateTime dateOfSign)
        {
            var d = db.Deals.Find(dealId);

            // пример выбора менеджера - берём первого
            var mgr = db.Managers.FirstOrDefault();
            if (mgr == null) return false;

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
        public bool TryLogin(string login, string password, out string role)
        {
            var manager = db.Managers.FirstOrDefault(m => m.Login == login && m.HashPassword == password);
            if (manager != null)
            {
                role = "Manager";
                return true;
            }

            var employee = db.Employees.FirstOrDefault(e => e.Login == login && e.HashPassword == password);
            if (employee != null)
            {
                role = "Employee";
                return true;
            }

            var employer = db.Employers.FirstOrDefault(e => e.Login == login && e.HashPassword == password);
            if (employer != null)
            {
                role = "Employer";
                return true;
            }

            role = null;
            return false;
        }

        public bool TryRegister(string login, string password, string role)
        {
            if (role == "Соискатель")
            {
                if (db.Employees.Any(e => e.Login == login))
                    return false;

                var employee = new Employee
                {
                    Login = login,
                    HashPassword = password,
                    FirstName = "",
                    LastName = "",
                    MiddleName = ""
                };
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
            else if (role == "Работодатель")
            {
                if (db.Employers.Any(e => e.Login == login))
                    return false;

                var employer = new Employer
                {
                    Login = login,
                    HashPassword = password,
                    CompanyName = ""
                };
                db.Employers.Add(employer);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
