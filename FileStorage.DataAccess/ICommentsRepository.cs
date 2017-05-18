using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileStorage.Model;

namespace FileStorage.DataAccess
{
    public interface ICommentsRepository
    {
        Comment Add(Comment comment);
        void Delete(Guid id);
        Comment Get(Guid id);
        void Edit(Guid id, string text);

        IEnumerable<Comment> GetFileComments(Guid fileId);
        IEnumerable<Comment> GetUserComments(Guid userId);
    }
}
