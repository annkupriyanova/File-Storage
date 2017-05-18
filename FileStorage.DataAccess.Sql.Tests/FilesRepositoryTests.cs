using System;
using FileStorage.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FileStorage.DataAccess.Sql.Tests
{
    [TestClass]
    public class FilesRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);
        private readonly IFilesRepository _filesRepository;

        private User TestUser { get; set; }

        public FilesRepositoryTests()
        {
            _filesRepository = new FilesRepository(ConnectionString, _usersRepository);
        }

        [TestInitialize]
        public void Init()
        {
            TestUser = _usersRepository.Add("testName", "test@test.com");
        }
            
        [TestCleanup]
        public void Clean()
        {
            if (TestUser != null)
            {
                foreach (var file in _filesRepository.GetAllowedFiles(TestUser.UserId))
                    _filesRepository.DeleteAccessToFile(TestUser.UserId, file.FileId);

                foreach (var file in _filesRepository.GetUserFiles(TestUser.UserId))
                {
                    foreach(var user in _usersRepository.GetAllowedUsers(file.FileId))
                        _filesRepository.DeleteAccessToFile(user.UserId, file.FileId);
                    _filesRepository.Delete(file.FileId);
                }

                _usersRepository.Delete(TestUser.UserId);
            }
        }    

        [TestMethod]
        public void ShouldCreateAndGetFile()
        {
            //arrange
            var content = Encoding.UTF8.GetBytes("Hello");
            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
                //Content = content,
                Size = content.Length,
                Owner = TestUser
            };
            //act
            var newFile = _filesRepository.Add(file);
            var result = _filesRepository.GetFileInfo(newFile.FileId);
            //asserts
            Assert.AreEqual(file.Owner.UserId, result.Owner.UserId);
            Assert.AreEqual(file.Name, result.Name);
            Assert.AreEqual(file.DateOfCreation.ToString(), result.DateOfCreation.ToString());
        }
  
        [TestMethod]
        public void ShoulUpdateAndGetFileContent()
        {
            //arrange
            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
                //Content = Encoding.UTF8.GetBytes(""),
                Size = 0,
                Owner = TestUser
            };
            var content = Encoding.UTF8.GetBytes("Hello");
            var newFile = _filesRepository.Add(file);
            //act
            _filesRepository.UpdateContent(newFile.FileId, content);
            var resultContent = _filesRepository.GetFileContent(newFile.FileId);
            //asserts
            Assert.IsTrue(content.SequenceEqual(resultContent));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldDeleteFile()
        {
            var content = Encoding.UTF8.GetBytes("Hello");
            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
                //Content = content,
                Size = content.Length,
                Owner = TestUser
            };

            var newFile = _filesRepository.Add(file);
            _filesRepository.Delete(newFile.FileId);
            var result = _filesRepository.GetFileInfo(newFile.FileId);
        }

        [TestMethod]
        public void ShouldGetUserFiles()
        {
            List<File> files = new List<File>();
            var content = Encoding.UTF8.GetBytes("Hello from file 1");
            var file1 = new File
            {
                Name = "testFile1",
                DateOfCreation = DateTime.Now,
                //Content = content,
                Size = content.Length,
                Owner = TestUser
            };
            content = Encoding.UTF8.GetBytes("Hello from file 2");
            var file2 = new File
            {
                Name = "testFile2",
                DateOfCreation = DateTime.Now,
                //Content = content,
                Size = content.Length,
                Owner = TestUser
            };
            files.Add(file1);
            files.Add(file2);

            var newFile1 = _filesRepository.Add(files[0]);
            var newFile2 = _filesRepository.Add(files[1]);
            var result = _filesRepository.GetUserFiles(TestUser.UserId);

            foreach(var res in result)
            {
                int i = files.FindIndex(f => f.FileId == res.FileId);
                Assert.AreEqual(files[i].Name, res.Name);
                Assert.AreEqual(files[i].Owner.UserId, res.Owner.UserId);
            }
        }

        [TestMethod]
        public void ShouldGiveAccessToFileAndGetAllowedFiles()
        {
            var content = Encoding.UTF8.GetBytes("Hello");
            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
                //Content = content,
                Size = content.Length,
                Owner = TestUser
            };

            var TestUser2 = _usersRepository.Add("testName2", "test2@test.com");
            var newFile = _filesRepository.Add(file);
            _filesRepository.GiveAccessToFile(TestUser2.UserId, newFile.FileId);
            var result = (List<File>)_filesRepository.GetAllowedFiles(TestUser2.UserId);

            int i = result.FindIndex(f => f.FileId == newFile.FileId);
            Assert.AreEqual(file.Name, result[i].Name);
            Assert.AreEqual(file.Owner.UserId, result[i].Owner.UserId);   
        }

        [TestMethod]
        public void ShouldDeleteAccessToFile()
        {
            var content = Encoding.UTF8.GetBytes("Hello");
            var file = new File
            {
                Name = "testFile",
                DateOfCreation = DateTime.Now,
               // Content = content,
                Size = content.Length,
                Owner = TestUser
            };

            var TestUser2 = _usersRepository.Add("testName2", "test2@test.com");
            var newFile = _filesRepository.Add(file);
            _filesRepository.GiveAccessToFile(TestUser2.UserId, newFile.FileId);
            _filesRepository.DeleteAccessToFile(TestUser2.UserId, newFile.FileId);
            var result = (List<File>)_filesRepository.GetAllowedFiles(TestUser2.UserId);

            Assert.IsNull(result.Find(f => f.FileId == newFile.FileId));
        }
    }
}
