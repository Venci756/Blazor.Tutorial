using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject] 
        public IEmployeeService EmployeeService { get; set; }
        
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        // private void LoadEmployees()
        // {
        //     Thread.Sleep(5000);
        //     Employee e1 = new Employee
        //     {    
        //         EmployeeId = 1,
        //         FirstName = "Cristy",
        //         LastName = "Hastings",
        //         Email = "Cristy@pragimtech.com",
        //         DateOfBirth = new DateTime(1980,10,5),
        //         Gender = Gender.Female,
        //         DepartmentId = 1,
        //         PhotoPath = "images/cristy.jpg"
        //         
        //     };
        //     Employee e2 = new Employee
        //     {    
        //         EmployeeId = 2,
        //         FirstName = "Danelle",
        //         LastName = "Galloway",
        //         Email = "Danelle@pragimtech.com",
        //         DateOfBirth = new DateTime(1981,12,22),
        //         Gender = Gender.Male,
        //         DepartmentId = 2,
        //         PhotoPath = "images/danelle.jpg"
        //         
        //     };
        //     Employee e3 = new Employee
        //     {    
        //         EmployeeId = 3,
        //         FirstName = "Sara",
        //         LastName = "Longway",
        //         Email = "sara@pragimtech.com",
        //         DateOfBirth = new DateTime(1988,4,15),
        //         Gender = Gender.Female,
        //        DepartmentId = 3,
        //         PhotoPath = "images/sara.jpg"
        //         
        //     };
        //     Employee e4 = new Employee
        //     {    
        //         EmployeeId = 4,
        //         FirstName = "Mary",
        //         LastName = "Smith",
        //         Email = "mary@pragimtech.com",
        //         DateOfBirth = new DateTime(1984,2,22),
        //         Gender = Gender.Female,
        //        DepartmentId = 4,
        //         PhotoPath = "images/mary.jpg"
        //         
        //     };
        //     Employees = new List<Employee> {e1,e2,e3,e4};
        // }
    }
}