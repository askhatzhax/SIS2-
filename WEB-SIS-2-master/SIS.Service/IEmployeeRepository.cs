using System;
using System.Collections.Generic;
using System.Text;
using SIS.Models;

namespace SIS.Services
{
    public interface IEmployeeRepository/*сдесь реализуются методы*, что он должен делать*/
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
