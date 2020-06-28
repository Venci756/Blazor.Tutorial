using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _db;

        public EmployeeRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = _db.Employees;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name)
                                         || e.LastName.Contains(name));
            }

            if (gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _db.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _db.Employees
                .Include(e => e.Department)
                .FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _db.Employees.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await _db.Employees.AddAsync(employee);
            await _db.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = _db.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await _db.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var result = await _db.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (result != null)
            {
                _db.Remove(result);
                await _db.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}