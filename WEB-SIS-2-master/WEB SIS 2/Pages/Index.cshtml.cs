using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEB_SIS_2.Pages
{
    public  class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "Hello Guys  & Girls";
        }
    }

    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items, string type)
        {
            string result = "<ul type=\"" + type + "\" >";
            foreach (string item in items) {
                result = result + "<li>" + item + "</li>";
            }
            result = result + "</ul>";
            return new HtmlString(result);
        }
        //public static HtmlString LoginForm(this IHtmlHelper html,string method)
        //{

        //}
    }
}
