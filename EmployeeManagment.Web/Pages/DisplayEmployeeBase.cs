﻿using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }
        
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }

        protected Venci.Components.ConfirmBase DeleteConfirmation { get; set; }
        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            await OnEmployeeSelection.InvokeAsync((bool) e.Value);
        }

        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            }
        }
        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }
        
    }
}