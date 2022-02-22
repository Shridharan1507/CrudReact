using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repository
{
    public interface IEmployee
    {

        ICollection<Employee> GetEmployees();

        string CreateEmp(Employee empnew);

        string Update(Employee empupd);

        string Delete(int empupd);

        bool ExistsAlready(Employee employee);

        bool ExistsAlreadyBasedOnId(int empid);
    }
}
