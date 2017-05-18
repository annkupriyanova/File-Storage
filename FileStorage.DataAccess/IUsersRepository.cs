using System;
using FileStorage.Model;
using System.Collections.Generic;

namespace FileStorage.DataAccess
{
    public interface IUsersRepository
    {
        User Add(string name, string email);
        void Delete(Guid id);
        User Get(Guid id);
        //void ChangePassword(Guid id, string password);

        IEnumerable<User> GetAllowedUsers(Guid fileId);
    }
}
