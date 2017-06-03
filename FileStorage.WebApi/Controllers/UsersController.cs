using FileStorage.DataAccess;
using FileStorage.DataAccess.Sql;
using FileStorage.Model;
using System;
using System.Collections.Generic;
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
            try
            {
                var newUser = _usersRepository.Add(user.Name, user.Email);
                Log.Logger.Servicelog.Info("Create user, id: {0}", newUser.UserId);
                return newUser;
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while creating new user | " + ex.Message);
                throw;
            }
           
        }

        [HttpDelete]
        public void DeleteUser(Guid id)
        {
            try
            {
                Log.Logger.Servicelog.Info("Delete user, id: {0}", id);
                _usersRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while deleting user, id: {0} | " + ex.Message, id);
                throw;
            }
            
        }

        [HttpGet]
        public User GetUser(Guid id)
        {
            try
            {
                return _usersRepository.Get(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting user, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [Route("api/users/{id}/files")]
        [HttpGet]
        public IEnumerable<File> GetUserFiles(Guid id)
        {
            try
            {
                return _filesRepository.GetUserFiles(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting user files, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [Route("api/users/{id}/sharings")]
        [HttpGet]
        public IEnumerable<File> GetUserAllowedFiles(Guid id)
        {
            try
            {
                return _filesRepository.GetAllowedFiles(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting user allowed files, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpGet]
        [Route("api/users/{id}/comments")]
        public IEnumerable<Comment> GetUserComments(Guid id)
        {
            try
            {
                return _commentsRepository.GetUserComments(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting user comments, id: {0} | " + ex.Message, id);
                throw;
            }
        }
    }
}