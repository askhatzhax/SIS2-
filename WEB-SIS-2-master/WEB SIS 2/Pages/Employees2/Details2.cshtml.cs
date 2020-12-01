using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SIS.Models;
using FGames.Services;
namespace WEB_SIS_2.Pages.Employees2
{
    public class Details2Model : PageModel
    {
        private readonly IEmployee2Repository _employeeRepository;

        public Details2Model(IEmployee2Repository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employee { get; private set; }

        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);
        }
    }
}
