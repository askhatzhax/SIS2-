using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Comments.Services;
using Comments.Models;
namespace WEB_SIS_2.Pages.Comments
{
    public class ViewsModel : PageModel
    {
        private readonly ICommentRepository _commentRepository;

        public ViewsModel(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment Comment { get; private set; }

        public IActionResult OnGet(int id)
        {
            Comment = _commentRepository.GetComment(id);
            if (Comment == null) {
                return RedirectToPage("/NotFound");
            }
            return Page();

        }
    }
}
