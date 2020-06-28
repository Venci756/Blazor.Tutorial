using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _db;
        public DepartmentRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _db.Departments.ToList();
        }

        public Department GetDepartment(int departmentId)
        {
            return _db.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
        }
    }
}