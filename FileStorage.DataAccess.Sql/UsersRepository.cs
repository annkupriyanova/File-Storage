using System;
using System.Data.SqlClient;
using FileStorage.Model;
using System.Collections.Generic;
using System.Text;

namespace FileStorage.DataAccess.Sql
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;

        public UsersRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User Add(string name, string email)
        {
            StringBuilder errorMessages = new StringBuilder();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    var id = Guid.NewGuid();

                    command.CommandText = "INSERT INTO Users (UserId, Name, Email) VALUES  (@UserId, @Name, @Email)";
                    command.Parameters.AddWithValue("@UserId", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);

                    //try
                    //{
                        command.ExecuteNonQuery();

                        return new User
                        {
                            UserId = id,
                            Name = name,
                            Email = email,
                        };
                    //}
                    /*
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        Console.WriteLine(errorMessages.ToString());
                        throw;
                    }
                    */
                }                    
            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Users WHERE UserId = @UserId";
                    command.Parameters.AddWithValue("@UserId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public User Get(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT UserId, Name, Email FROM Users WHERE UserId = @UserId";
                    command.Parameters.AddWithValue("@UserId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new User
                            {
                                UserId = Guid.Parse(reader.GetString(reader.GetOrdinal("UserId"))),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                            };
                        }
                        throw new ArgumentException("User not found");
                    }
                }
            }
        }

        public IEnumerable<User> GetAllowedUsers(Guid fileId)
        {
            var result = new List<User>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT UserId FROM Sharings WHERE FileId = @FileId";
                    command.Parameters.AddWithValue("@FileId", fileId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(Get(Guid.Parse(reader.GetString(reader.GetOrdinal("UserId")))));
                        }
                        return result;
                    }
                }
            }
        } 

    }
}
