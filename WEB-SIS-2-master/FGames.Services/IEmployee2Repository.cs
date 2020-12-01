using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable CS0246 // Не удалось найти тип или имя пространства имен "SIS" (возможно, отсутствует директива using или ссылка на сборку).
using SIS.Models;
#pragma warning restore CS0246 // Не удалось найти тип или имя пространства имен "SIS" (возможно, отсутствует директива using или ссылка на сборку).
namespace FGames.Services
{
    public interface IEmployee2Repository
    {
#pragma warning disable CS0246 // Не удалось найти тип или имя пространства имен "Employee" (возможно, отсутствует директива using или ссылка на сборку).
        IEnumerable<Employee> GetAllEmployees();
#pragma warning restore CS0246 // Не удалось найти тип или имя пространства имен "Employee" (возможно, отсутствует директива using или ссылка на сборку).
#pragma warning disable CS0246 // Не удалось найти тип или имя пространства имен "Employee" (возможно, отсутствует директива using или ссылка на сборку).
        Employee GetEmployee(int id);
#pragma warning restore CS0246 // Не удалось найти тип или имя пространства имен "Employee" (возможно, отсутствует директива using или ссылка на сборку).
    }
}
