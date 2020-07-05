using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _db;
        public DepartmentRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _db.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await _db.Departments.FirstOrDefaultAsync(x => x.DepartmentId == departmentId);
        }
    }
}