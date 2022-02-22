using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public interface IDepartment
    {
        ICollection<Department> GetDepartments();

        string CreateDep(Department empnew);

        string Update(Department empupd);

        string Delete(int empupd);

        bool ExistsAlready(Department employee);

        bool ExistsAlreadyBasedOnId(int empid);
    }
}
