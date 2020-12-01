using System;
using System.Collections.Generic;
#pragma warning disable CS0246 // Не удалось найти тип или имя пространства имен "SIS" (возможно, отсутствует директива using или ссылка на сборку).
using SIS.Models;
#pragma warning restore CS0246 // Не удалось найти тип или имя пространства имен "SIS" (возможно, отсутствует директива using или ссылка на сборку).
using System.Text;
using System.Linq;

namespace FGames.Services
{
#pragma warning disable CS0535 // '"MockEmployee2Repository" не реализует член интерфейса "IEmployee2Repository.GetEmployee()".
    public class MockEmployee2Repository : IEmployee2Repository
#pragma warning restore CS0535 // '"MockEmployee2Repository" не реализует член интерфейса "IEmployee2Repository.GetEmployee()".
    {
        private List<Employee> _employeeList;


        public MockEmployee2Repository()
        {
            _employeeList = new List<Employee>() {
                new Employee()
                {
                    Id=9, Name="PES2021",Price=1795, PhotoPath="avatar9.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=10, Name="NFC Underground2",Price= 2625, PhotoPath="avatar10.jpg", Discount="100%", Genre=Dept.Sport
                },
                new Employee()
                {
                    Id=11, Name="Worms-Rumble",Price= 1139, PhotoPath="avatar11.jpg", Discount="100%", Genre =Dept.Shooter
                },
                new Employee()
                {
                    Id=12, Name="WSP-2",Price=499 , PhotoPath="avatar12.jpg", Discount="100%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=13, Name="NBA2021",Price=475 , PhotoPath="avatar13.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=14, Name="Tennis world tour",Price=149 , PhotoPath="avatar14.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=15, Name="Tokyo-Ghoul",Price=249 , PhotoPath="avatar15.jpg", Discount="100%", Genre =Dept.Role
                },
                new Employee()
                {
                    Id=16, Name="FManager 2021",Price=399 , PhotoPath="avatar16.jpg", Discount="100%", Genre=Dept.Sport
                },
                new Employee()
                {
                    Id=17, Name="The Last of Us",Price=2625 , PhotoPath="avatar17.jpg", Discount="100%", Genre=Dept.Adventures
                },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
#pragma warning restore CS0246 // Не удалось найти тип или имя пространства имен "Employee" (возможно, отсутствует директива using или ссылка на сборку).
        {
            return _employeeList;//throw new NotImplementedException();
        }
        public Employee GetEmployee(int id)


        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
