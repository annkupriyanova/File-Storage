using FileStorage.DataAccess;
using FileStorage.DataAccess.Sql;
using FileStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileStorage.WebApi.Controllers
{
    public class CommentsController : ApiController
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);
        private readonly IFilesRepository _filesRepository;
        private readonly ICommentsRepository _commentsRepository;

        public CommentsController()
        {
            _filesRepository = new FilesRepository(ConnectionString, _usersRepository);
            _commentsRepository = new CommentsRepository(ConnectionString, _usersRepository, _filesRepository);
        }

        [HttpPost]
        public Comment CreateComment([FromBody]Comment comment)
        {
            return _commentsRepository.Add(comment);
        }

        [HttpGet]
        [Route("api/comments/{id}")]
        public Comment GetComment(Guid id)
        {
            return _commentsRepository.Get(id);
        }

        [HttpDelete]
        [Route("api/comments/{id}")]
        public void DeleteComment(Guid id)
        {
            _commentsRepository.Delete(id);
        }

        [HttpPut]
        [Route("api/comments/{id}")]
        public void EditComment(Guid id, [FromBody]Comment comment)
        {
            _commentsRepository.Edit(id, comment.Text);
        }
    }
}
