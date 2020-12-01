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
                    Id=10, Name="PES2021",Price=1795, PhotoPath="efootball-pes-2021-season-update-fc-barcelona-edition.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=11, Name="NFC Underground2",Price= 2625, PhotoPath="nfc.jpg", Discount="100%", Genre=Dept.Sport
                },
                new Employee()
                {
                    Id=12, Name="Worms-Rumble",Price= 1139, PhotoPath="worms-rumble.jpg", Discount="100%", Genre =Dept.Shooter
                },
                new Employee()
                {
                    Id=13, Name="WSP-2",Price=499 , PhotoPath="wreckfest-season-pass-2.jpg", Discount="100%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=14, Name="NBA2021",Price=475 , PhotoPath="nba-2k21-mamba-forever-edition.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=15, Name="Tennis world tour",Price=149 , PhotoPath="tennis-world-tour-2.jpg", Discount="100%", Genre =Dept.Sport
                },
                new Employee()
                {
                    Id=16, Name="Tokyo-Ghoul",Price=249 , PhotoPath="tokyo-ghoul.jpg", Discount="100%", Genre =Dept.Role
                },
                new Employee()
                {
                    Id=17, Name="FManager 2021",Price=399 , PhotoPath="football-manager-2021.jpg", Discount="100%", Genre=Dept.Sport
                },
                new Employee()
                {
                    Id=18, Name="The Last of Us",Price=2625 , PhotoPath="LAST2.jpg", Discount="100%", Genre=Dept.Adventures
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
