using System;
using System.Collections.Generic;
using System.Text;
using Comments.Models;

namespace Comments.Services
{
    public class MockCommentRepository : ICommentRepository
    {
        private List<Comment> _commentsList;
        public MockCommentRepository()
        {
            _commentsList = new List<Comment>()
            {
                new Comment()
                {
                    Id=0,Name="Cyberpunk 2077", Email ="as.gmail.com", PhotoPath="avatar0.jpg",GamesVariants= Games.None, Raiting="10/10", Date="29.11.2020"
                },
               new Comment()
                {
                    Id=1,Name="The Wither 3", Email ="as2.gmail.com", PhotoPath="avatar2.jpg",GamesVariants= Games.None, Raiting="10/10",Date = "03.12.2020"
        },
               new Comment()
                {
                    Id=2,Name="PES2021", Email ="as3.gmail.com", PhotoPath="avatar9.jpg",GamesVariants= Games.None, Raiting="10/10",Date= "27.12.2020"
        },
            };

        }
        public IEnumerable<Comment> GetAllComments()
        {
            return _commentsList;

        }
    }
}
