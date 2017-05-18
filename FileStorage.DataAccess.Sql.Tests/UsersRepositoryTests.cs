using System;
using FileStorage.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileStorage.DataAccess.Sql.Tests
{
    [TestClass]
    public class UsersRepositoryTests
    {
        private const string ConnectionString = @"Data Source=DESKTOP-BULUB4B\SQLEXPRESS;Initial Catalog=Dropbox;Integrated Security=True";
        private readonly IUsersRepository _usersRepository = new UsersRepository(ConnectionString);

        [TestMethod]
        public void ShouldCreateAndGetUser()
        {
            User testUser = new User
            {
                Name = "Tony",
                Email = "tony@test.com"
            };

            var newUser = _usersRepository.Add(testUser.Name, testUser.Email);
            var result = _usersRepository.Get(newUser.UserId);

            Assert.AreEqual(newUser.Name, result.Name);
            Assert.AreEqual(newUser.Email, result.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldDeleteUser()
        {
            User testUser = new User
            {
                Name = "Tony",
                Email = "tony@test.com"
            };

            var newUser = _usersRepository.Add(testUser.Name, testUser.Email);
            _usersRepository.Delete(newUser.UserId);
            var result = _usersRepository.Get(newUser.UserId);
        }
    }
}
