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
    public class Employees2Model : PageModel
    {
        private readonly IEmployee2Repository _db;
        public Employees2Model (IEmployee2Repository db)
        {
            _db = db;
        }
        public IEnumerable<Employee> Employees2 { get; set; }
        public void OnGet()
        {
            Employees2 = _db.GetAllEmployees();

        }
    }
}
