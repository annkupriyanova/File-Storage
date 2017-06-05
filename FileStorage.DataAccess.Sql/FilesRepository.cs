using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using FileStorage.Model;

namespace FileStorage.DataAccess.Sql
{
    public class FilesRepository : IFilesRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;

        public FilesRepository(string connectionString, IUsersRepository usersRepository)
        {
            _connectionString = connectionString;
            _usersRepository = usersRepository;
        }

        public File Add(File file)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    Guid id = Guid.NewGuid();
                    DateTime date = DateTime.Now;

                    command.CommandText = "INSERT INTO Files (FileId, Name, DateOfCreation, Size, OwnerId) VALUES (@FileId, @Name, @DateOfCreation,  @Size, @OwnerId)";
                    command.Parameters.AddWithValue("@FileId", id);
                    command.Parameters.AddWithValue("@Name", file.Name);
                    command.Parameters.AddWithValue("@DateOfCreation", date);
                    command.Parameters.AddWithValue("@Size", 0);
                    command.Parameters.AddWithValue("@OwnerId", file.Owner.UserId);
                    command.ExecuteNonQuery();

                    file.FileId = id;
                    file.DateOfCreation = date;
                    file.Size = 0;
                    return file;
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
                    command.CommandText = "DELETE FROM Files WHERE FileId = @FileId";
                    command.Parameters.AddWithValue("@FileId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public File GetFileInfo(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT FileId, Name, DateOfCreation, Size, OwnerId FROM Files WHERE FileId = @FileId";
                    command.Parameters.AddWithValue("@FileId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new File
                            {
                                FileId = Guid.Parse(reader.GetString(reader.GetOrdinal("FileId"))),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                DateOfCreation = reader.GetDateTime(reader.GetOrdinal("DateOfCreation")),
                                Size = reader.GetDouble(reader.GetOrdinal("Size")),
                                Owner = _usersRepository.Get(Guid.Parse(reader.GetString(reader.GetOrdinal("OwnerId")))),
                            };
                        }
                        throw new ArgumentException("File not found");
                    }
                }
            }
        }

        public byte[] GetFileContent(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Content FROM Files WHERE FileId = @FileId";
                    command.Parameters.AddWithValue("@FileId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            return reader.GetSqlBinary(reader.GetOrdinal("Content")).Value;
                        throw new ArgumentException($"File {id} not found");
                    }
                }
            }
        }

        public void UpdateContent(Guid id, byte[] content)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Files SET Content = @Content, Size = @Size where FileId = @FileId";
                    command.Parameters.AddWithValue("@Content", content);
                    command.Parameters.AddWithValue("@Size", content.Length/1000);
                    command.Parameters.AddWithValue("@FileId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<File> GetUserFiles(Guid userId)
        {
            var result = new List<File>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT FileId FROM Files WHERE OwnerId = @OwnerId";
                    command.Parameters.AddWithValue("@OwnerId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(GetFileInfo(Guid.Parse(reader.GetString(reader.GetOrdinal("FileId")))));
                        }
                        return result;
                    }
                }
            }
        }

        public void GiveAccessToFile(Guid userId, Guid fileId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Sharings (UserId, FileId) VALUES (@UserId, @FileId)";
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FileId", fileId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAccessToFile(Guid userId, Guid fileId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Sharings WHERE UserId = @UserId AND FileId = @FileId";
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FileId", fileId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<File> GetAllowedFiles(Guid userId)
        {
            var result = new List<File>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT FileId FROM Sharings WHERE UserId = @UserId";
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(GetFileInfo(Guid.Parse(reader.GetString(reader.GetOrdinal("FileId")))));
                        }
                        return result;
                    }
                }
            }
        }
    }
}
