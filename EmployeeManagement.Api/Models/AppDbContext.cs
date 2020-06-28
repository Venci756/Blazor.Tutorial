using System;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department {DepartmentId = 1,DepartmentName = "IT"}
                );
            modelBuilder.Entity<Department>().HasData(
                new Department {DepartmentId = 2,DepartmentName = "HR"}
            );
            modelBuilder.Entity<Department>().HasData(
                new Department {DepartmentId = 3,DepartmentName = "Payroll"}
            );
            modelBuilder.Entity<Department>().HasData(
                new Department {DepartmentId = 4,DepartmentName = "Admin"}
            );
            
            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Cristy",
                    LastName = "Hastings",
                    Email = "Cristy@pragimtech.com",
                    DateOfBirth = new DateTime(1980,10,5),
                    Gender = Gender.Female,
                    DepartmentId = 1,
                    PhotoPath = "images/cristy.jpg"
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Danelle",
                    LastName = "Galloway",
                    Email = "Danelle@pragimtech.com",
                    DateOfBirth = new DateTime(1981,12,22),
                    Gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "images/danelle.jpg"
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Sara",
                    LastName = "Longway",
                    Email = "sara@pragimtech.com",
                    DateOfBirth = new DateTime(1988,4,15),
                    Gender = Gender.Female,
                    DepartmentId = 3,
                    PhotoPath = "images/sara.jpg"
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email = "mary@pragimtech.com",
                    DateOfBirth = new DateTime(1984,2,22),
                    Gender = Gender.Female,
                    DepartmentId = 4,
                    PhotoPath = "images/mary.jpg"
                }
            );
        }
    }
}