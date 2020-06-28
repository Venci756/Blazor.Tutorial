﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagment.Web.Services
{
    public interface IEmployeeService
    {
       Task<IEnumerable<Employee>> GetEmployees();
       Task<Employee> GetEmployee(int id);
    }
}