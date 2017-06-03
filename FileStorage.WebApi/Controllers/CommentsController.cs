using FileStorage.DataAccess;
using FileStorage.DataAccess.Sql;
using FileStorage.Model;
using System;
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
            try
            {
                var newComment = _commentsRepository.Add(comment);
                Log.Logger.Servicelog.Info("Create comment, id: {0}", newComment.CommentId);
                return newComment;
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while creating new comment | " + ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("api/comments/{id}")]
        public Comment GetComment(Guid id)
        {
            try
            {
                return _commentsRepository.Get(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while getting comment, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpDelete]
        [Route("api/comments/{id}")]
        public void DeleteComment(Guid id)
        {
            try
            {
                Log.Logger.Servicelog.Info("Delete comment, id: {0}", id);
                _commentsRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while deleting comment, id: {0} | " + ex.Message, id);
                throw;
            }
        }

        [HttpPut]
        [Route("api/comments/{id}")]
        public void EditComment(Guid id, [FromBody]Comment comment)
        {
            try
            {
                Log.Logger.Servicelog.Info("Edit comment, id: {0}", id);
                _commentsRepository.Edit(id, comment.Text);
            }
            catch (Exception ex)
            {
                Log.Logger.Servicelog.Error("Error while editting comment, id: {0} | " + ex.Message, id);
                throw;
            }
        }
    }
}
