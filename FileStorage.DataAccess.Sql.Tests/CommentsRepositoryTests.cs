using System;
using FileStorage.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FileStorage.DataAccess.Sql.Tests
{
    [TestClass]
    public class CommentsRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);
        private readonly IFilesRepository _filesRepository;
        private readonly ICommentsRepository _commentsRepository;

        private User TestUser { get; set; }
        private File TestFile { get; set; }

        public CommentsRepositoryTests()
        {
            _filesRepository = new FilesRepository(ConnectionString, _usersRepository);
            _commentsRepository = new CommentsRepository(ConnectionString, _usersRepository, _filesRepository);
        }

        [TestInitialize]
        public void Init()
        {
            TestUser = _usersRepository.Add("testName", "test@test.com");

            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
                Size = 0,
                Owner = TestUser
            };
            TestFile = _filesRepository.Add(file);
        }

        [TestCleanup]
        public void Clean()
        {
            if (TestUser != null)
            {
                foreach (var file in _filesRepository.GetUserFiles(TestUser.UserId))
                {
                    foreach (var comment in _commentsRepository.GetFileComments(file.FileId))
                        _commentsRepository.Delete(comment.CommentId);

                    _filesRepository.Delete(file.FileId);
                }
                _usersRepository.Delete(TestUser.UserId);
            }
        }

        [TestMethod]
        public void ShouldCreateAndGetComment()
        {
            var comment = new Comment
            {
                Text = "It's a new comment",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };

            var newComment = _commentsRepository.Add(comment);
            var result = _commentsRepository.Get(newComment.CommentId);

            Assert.AreEqual(comment.Text, result.Text);
            Assert.AreEqual(comment.Date.ToString(), result.Date.ToString());
            Assert.AreEqual(comment.Author.UserId, result.Author.UserId);
            Assert.AreEqual(comment.File.FileId, result.File.FileId);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldDeleteComment()
        {
            var comment = new Comment
            {
                Text = "It's a new comment",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };

            var newComment = _commentsRepository.Add(comment);
            _commentsRepository.Delete(newComment.CommentId);
            var result = _commentsRepository.Get(newComment.CommentId);
        }

        [TestMethod]
        public void ShouldEditComment()
        {
            var comment = new Comment
            {
                Text = "It's a new comment",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };
            var text = "Edited comment";

            var newComment = _commentsRepository.Add(comment);
            _commentsRepository.Edit(newComment.CommentId, text);
            var result = _commentsRepository.Get(newComment.CommentId);

            Assert.AreEqual(text, result.Text);
        }

        [TestMethod]
        public void ShouldGetFileComments()
        {
            List<Comment> comments = new List<Comment>();
            var comment1 = new Comment
            {
                Text = "It's a comment 1",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };
            var comment2 = new Comment
            {
                Text = "It's a comment 2",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };
            comments.Add(comment1);
            comments.Add(comment2);

            var newComment1 = _commentsRepository.Add(comments[0]);
            var newComment2 = _commentsRepository.Add(comments[1]);
            var result = (List<Comment>)_commentsRepository.GetFileComments(TestFile.FileId);

            foreach(var res in result)
            {
                int i = comments.FindIndex(com => com.CommentId == res.CommentId);
                Assert.AreEqual(comments[i].Text, res.Text);
                Assert.AreEqual(comments[i].File.FileId, res.File.FileId);
                Assert.AreEqual(comments[i].Author.UserId, res.Author.UserId);
            }
        }

        [TestMethod]
        public void ShouldGetUserComments()
        {
            List<Comment> comments = new List<Comment>();
            var comment1 = new Comment
            {
                Text = "It's a comment 1",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };
            var comment2 = new Comment
            {
                Text = "It's a comment 2",
                Date = DateTime.Now,
                Author = TestUser,
                File = TestFile
            };
            comments.Add(comment1);
            comments.Add(comment2);

            var newComment1 = _commentsRepository.Add(comments[0]);
            var newComment2 = _commentsRepository.Add(comments[1]);
            var result = (List<Comment>)_commentsRepository.GetUserComments(TestUser.UserId);

            foreach (var res in result)
            {
                int i = comments.FindIndex(com => com.CommentId == res.CommentId);
                Assert.AreEqual(comments[i].Text, res.Text);
                Assert.AreEqual(comments[i].File.FileId, res.File.FileId);
                Assert.AreEqual(comments[i].Author.UserId, res.Author.UserId);
            }
        }
    }
}
