using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_SIS_2.Models2
{
    public class ReviewDBContext : DbContext
    {
        public ReviewDBContext(DbContextOptions<ReviewDBContext> o) : base(o)
        {

        }
        public DbSet<Review> Reviews { get; set; }
    }
}
