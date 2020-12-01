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
    public class CommentsModel : PageModel
    {
        private readonly ICommentRepository _db;
        public CommentsModel(ICommentRepository db)
        {
            _db = db;
        }
         public IEnumerable<Comment> Comments { get; set; }
        public void OnGet()
        {
            Comments = _db.GetAllComments();
        }
    }
}
