using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public class DepartmentService : IDepartment
    {
        private readonly EmplContext _emp;

        public DepartmentService(EmplContext emp)
        {
            _emp = emp;
        }
        public string CreateDep(Department empnew)
        {
            _emp.Departments.Add(empnew);
            _emp.SaveChanges();
            return "Created Sucessfully";

        }

        public ICollection<Department> GetDepartments()
        {
            return _emp.Departments.OrderBy(x => x.DepartmentName).ToList();
        }

       
        public bool ExistsAlready(Department employee)
        {
            bool value = _emp.Departments.Any(a => a.DepartmentName.ToLower().Trim() == employee.DepartmentName.ToLower().Trim());
            return value;
        }
        public string Delete(int empupd)
        {
            Department emp = _emp.Departments.Where(x => x.DepartmentId == empupd).Single<Department>();
            _emp.Departments.Remove(emp);
            _emp.SaveChanges();
            return "Deleted Successfully";

        }

        public bool ExistsAlreadyBasedOnId(int empid)
        {
            bool value = _emp.Departments.Any(a => a.DepartmentId == empid);
            return value;
        }

        public string Update(Department empupd)
        {
            _emp.Departments.Update(empupd);
            _emp.SaveChanges();
            return "Updated Sucessfully";

        }
    }
}
