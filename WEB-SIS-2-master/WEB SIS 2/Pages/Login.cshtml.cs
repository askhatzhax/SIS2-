using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_SIS_2.Models;

namespace WEB_SIS_2.Pages
{
    public class LoginModel : PageModel
    {
        private readonly WEB_SIS_2.Models.LoginDBContext _context;

        public LoginModel(WEB_SIS_2.Models.LoginDBContext context)
        {
            _context = context;
        }

        public User User { get; set; }
        public void OnPost(string Login, string Password)
        {
            User = _context.Users.FirstOrDefault(x => (x.Login.ToLower().Equals(Login.ToLower()) && x.Password.ToLower().Equals(Password.ToLower())));

            if (User == null) {
                User = new User();
                User.Login = "none";
                User.Password = "none";
                User.Email = "none";
            }
        }
    }
}
