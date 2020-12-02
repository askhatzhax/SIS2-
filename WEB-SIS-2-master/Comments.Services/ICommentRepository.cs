using System;
using System.Collections.Generic;
using System.Text;
using Comments.Models;

namespace Comments.Services
{
    public interface ICommentRepository//обозначаем что должен делать наш интерфейс
    {
        IEnumerable<Comment> GetAllComments();
        Comment GetComment(int id);

    }
}
