using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagment.Web.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}