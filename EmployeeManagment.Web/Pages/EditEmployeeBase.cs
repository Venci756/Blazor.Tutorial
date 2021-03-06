﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagment.Web.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using Venci.Components;

namespace EmployeeManagment.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject] public IEmployeeService EmployeeService { get; set; }

        public string PageHeaderText { get; set; }
        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject] public IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        //public Guid DepartmentId { get; set; }

        [Parameter] public string Id { get; set; }

        [Inject] public IMapper Mapper { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }
        public ConfirmBase DeleteConfirmation { get; set; }

        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);

            if (employeeId != 0)
            {
                PageHeaderText = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Employee";
                Employee = new Employee()
                {
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }


            Departments = (await DepartmentService.GetDepartments()).ToList();
            //DepartmentId = Employee.DepartmentId.ToString();
            //DepartmentId = Guid.NewGuid();

            Mapper.Map(Employee, EditEmployeeModel);

            // EditEmployeeModel.EmployeeId = Employee.EmployeeId;
            // EditEmployeeModel.FirstName = Employee.FirstName;
            // EditEmployeeModel.LastName = Employee.LastName;
            // EditEmployeeModel.Email = Employee.Email;
            // EditEmployeeModel.ConfirmEmail = Employee.Email;
            // EditEmployeeModel.DateOfBirth = Employee.DateOfBirth;
            // EditEmployeeModel.Gender = Employee.Gender;
            // EditEmployeeModel.PhotoPath = Employee.PhotoPath;
            // EditEmployeeModel.DepartmentId = Employee.DepartmentId;
            // EditEmployeeModel.Department = Employee.Department;
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);
            Employee result = null;

            if (Employee.EmployeeId != 0)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }


            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }
        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                NavigationManager.NavigateTo("/");
            }
        }
    }
}