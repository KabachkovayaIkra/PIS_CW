﻿using System.Data.Entity;
using DataAccess.Models;

public class DataContext : DbContext
{
    public DataContext() : base("name=test22") { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<TypeOfBusiness> TypesOfBusiness { get; set; }
    public DbSet<Vacancy> Vacancies { get; set; }
    public DbSet<Deal> Deals { get; set; }
}