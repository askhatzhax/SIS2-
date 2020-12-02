using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_SIS_2.Models2;

namespace WEB_SIS_2.Pages
{
    public class Index2Model : PageModel
    {
        private readonly WEB_SIS_2.Models2.ReviewDBContext _context;

        public Index2Model(WEB_SIS_2.Models2.ReviewDBContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; }

        public async Task OnGetAsync()
        {
            Review = await _context.Reviews.ToListAsync();
        }
    }
}
