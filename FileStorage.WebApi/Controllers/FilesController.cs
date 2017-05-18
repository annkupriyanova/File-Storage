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
            return _filesRepository.Add(file);
        }

        [HttpGet]
        public File GetFileInfo(Guid id)
        {
            return _filesRepository.GetFileInfo(id);
        }
        
        [HttpGet]
        [Route("api/files/{id}/content")]
        public byte[] GetFileContent(Guid id)
        {
            return _filesRepository.GetFileContent(id);
        }

        [HttpDelete]
        public void DeleteFile(Guid id)
        {
            _filesRepository.Delete(id);
        }

        [HttpPut]
        [Route("api/files/{id}/content")]
        public async Task UpdateFileContent(Guid id)
        {
            var bytes = await Request.Content.ReadAsByteArrayAsync();
            _filesRepository.UpdateContent(id, bytes);
        }

        [Route("api/files/{fileId}/sharings")]
        [HttpPut]
        public void GiveAccessToFile(Guid fileId, [FromBody]Guid userId)
        {
            _filesRepository.GiveAccessToFile(userId, fileId);
        }

        [Route("api/files/{fileId}/sharings/{userId}")]
        [HttpDelete]
        public void DeleteAccessToFile(Guid fileId, Guid userId)
        {
            _filesRepository.DeleteAccessToFile(userId, fileId);
        }

        [HttpGet]
        [Route("api/files/{id}/comments")]
        public IEnumerable<Comment> GetFileComments(Guid id)
        {
            return _commentsRepository.GetFileComments(id);
        }
    }
}
