using FileStorage.DataAccess;
using FileStorage.DataAccess.Sql;
using FileStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FileStorage.WebApi.Controllers
{
    public class FilesController : ApiController
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);
        private readonly IFilesRepository _filesRepository;
        private readonly ICommentsRepository _commentsRepository;

        public FilesController()
        {
            _filesRepository = new FilesRepository(ConnectionString, _usersRepository);
            _commentsRepository = new CommentsRepository(ConnectionString, _usersRepository, _filesRepository);
        }

        [HttpPost]
        public File CreateFile(File file)
        {
            try
            {
                var newFile = _filesRepository.Add(file);
                Log.Logger.Servicelog.Info("Create file, id: {0}", file.FileId);
                return newFile;
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while creating new file | " + ex.Message);
                throw;
            }
        }

        [HttpGet]
        public File GetFileInfo(Guid id)
        {
            try
            {
                return _filesRepository.GetFileInfo(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting file info, id: {0} | " + ex.Message, id);
                throw;
            }
        }
        
        [HttpGet]
        [Route("api/files/{id}/content")]
        public byte[] GetFileContent(Guid id)
        {
            try
            {
                return _filesRepository.GetFileContent(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting file content, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpDelete]
        public void DeleteFile(Guid id)
        {
            try
            {
                Log.Logger.Servicelog.Info("Delete file, id: {0}", id);
                _filesRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while deleting file, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpPut]
        [Route("api/files/{id}/content")]
        public async Task UpdateFileContent(Guid id)
        {
            try
            {
                Log.Logger.Servicelog.Info("Update content of file, id: {0}", id);
                var bytes = await Request.Content.ReadAsByteArrayAsync();
                _filesRepository.UpdateContent(id, bytes);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while updating file content, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [Route("api/files/{fileId}/sharings")]
        [HttpPut]
        public void GiveAccessToFile(Guid fileId, [FromBody]Guid userId)
        {
            try
            {
                Log.Logger.Servicelog.Info("Give access to file, id: {0} to user, id: {1} ", fileId, userId);
                _filesRepository.GiveAccessToFile(userId, fileId);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while giving user with id: {0} access to file, id: {1} | " + ex.Message, userId, fileId);
                throw;
            }
        }

        [Route("api/files/{fileId}/sharings/{userId}")]
        [HttpDelete]
        public void DeleteAccessToFile(Guid fileId, Guid userId)
        {
            try
            {
                Log.Logger.Servicelog.Info("Delete access to file, id: {0} for user, id: {1} ", fileId, userId);
                _filesRepository.DeleteAccessToFile(userId, fileId);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while deleting access to file with id: {0} to user, id: {1} | " + ex.Message, fileId, userId);
                throw;
            }
        }

        [HttpGet]
        [Route("api/files/{id}/comments")]
        public IEnumerable<Comment> GetFileComments(Guid id)
        {
            try
            {
                return _commentsRepository.GetFileComments(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting file comments, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpGet]
        [Route("api/files/{id}/sharings")]
        public IEnumerable<User> GetAllowedUsers(Guid id)
        {
            try
            {
                return _usersRepository.GetAllowedUsers(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting allowed users for file, id: {0} | " + ex.Message, id);
                throw;
            }
        }
    }
}
