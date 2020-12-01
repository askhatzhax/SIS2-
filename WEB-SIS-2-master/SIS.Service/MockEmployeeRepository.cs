using System;
using System.Collections.Generic;
using SIS.Models;
using System.Text;
using System.Linq;

namespace SIS.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() {
                new Employee()
                {
                    Id=0, Name="Cyberpunk 2077",Price=1795, PhotoPath="avtar2.jpg", Discount="10%", Genre =Dept.Role
                },               
                new Employee()
                {
                    Id=1, Name="Fifa 21",Price= 2625, PhotoPath="avtar6.jpg", Discount="25%", Genre=Dept.Sport
                },
                new Employee()
                {
                    Id=2, Name="THE WITCHER 3",Price= 1139, PhotoPath="avtar7.jpg", Discount="5%", Genre =Dept.Role
                },
                new Employee()
                {
                    Id=3, Name="Far Cry 5",Price=499 , PhotoPath="avtar1.jpg", Discount="80%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=4, Name="PUBG",Price=475 , PhotoPath="avtar0.jpg", Discount="50%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=5, Name="NARUTO SHIPPUDEN",Price=149 , PhotoPath="avtar3.jpg", Discount="80%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=6, Name="ASSASSIN'S CREED",Price=249 , PhotoPath="avtar4.jpg", Discount="80%", Genre =Dept.Adventures
                },
                new Employee()
                {
                    Id=7, Name="Dark Souls 3",Price=399 , PhotoPath="avtar5.jpg", Discount="80%", Genre=Dept.Role
                },
                new Employee()
                {
                    Id=8, Name="GTA V",Price=2625 , PhotoPath="avtar8.jpg", Discount="60%", Genre=Dept.Adventures
                },
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;//throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
