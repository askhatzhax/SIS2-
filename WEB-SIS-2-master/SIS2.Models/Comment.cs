using System;
using System.Collections.Generic;
using System.Text;

namespace Comments.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Raiting { get; set; }
        public string PhotoPath { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public Games? GamesVariants { get; set; }
    }
}
