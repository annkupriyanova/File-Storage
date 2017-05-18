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
    public class UsersController : ApiController
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);
        private readonly IFilesRepository _filesRepository;
        private readonly ICommentsRepository _commentsRepository;

        public UsersController()
        {
            _filesRepository = new FilesRepository(ConnectionString, _usersRepository);
            _commentsRepository = new CommentsRepository(ConnectionString, _usersRepository, _filesRepository);
        }

        [HttpPost]
        public User CreateUser([FromBody]User user)
        {
            return _usersRepository.Add(user.Name, user.Email);
        }

        [HttpDelete]
        public void DeleteUser(Guid id)
        {
            _usersRepository.Delete(id);
        }

        [HttpGet]
        public User GetUser(Guid id)
        {
            return _usersRepository.Get(id);
        }

        [Route("api/users/{id}/files")]
        [HttpGet]
        public IEnumerable<File> GetUserFiles(Guid id)
        {
            return _filesRepository.GetUserFiles(id);
        }

        [Route("api/users/{id}/sharings")]
        [HttpGet]
        public IEnumerable<File> GetUserAllowedFiles(Guid id)
        {
            return _filesRepository.GetAllowedFiles(id);
        }

        [HttpGet]
        [Route("api/users/{id}/comments")]
        public IEnumerable<Comment> GetUserComments(Guid id)
        {
            return _commentsRepository.GetUserComments(id);
        }
    }
}
