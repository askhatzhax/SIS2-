using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_SIS_2.Models
{
    public class LoginDBContext : DbContext
    {
        
        public LoginDBContext(DbContextOptions<LoginDBContext> ops) : base(ops)
        {

        }

        public DbSet<User> Users { get; set; }
        
    }
}
