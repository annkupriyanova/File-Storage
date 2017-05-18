using System;
using System.Data.SqlClient;
using FileStorage.Model;
using System.Collections.Generic;

namespace FileStorage.DataAccess.Sql
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly string _connectionString;
        private readonly IFilesRepository _filesRepository;
        private readonly IUsersRepository _usersRepository;

        public CommentsRepository(string connectionString, IUsersRepository usersRepository, IFilesRepository filesRepository)
        {
            _connectionString = connectionString;
            _filesRepository = filesRepository;
            _usersRepository = usersRepository;
        }

        public Comment Add(Comment comment)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    Guid id = Guid.NewGuid();
                    DateTime date = DateTime.Now;
                    command.CommandText = "INSERT INTO Comments VALUES (@CommentId, @Text, @Date, @AuthorId, @FileId)";
                    command.Parameters.AddWithValue("@CommentId", id);
                    command.Parameters.AddWithValue("@Text", comment.Text);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@AuthorId", comment.Author.UserId);
                    command.Parameters.AddWithValue("@FileId", comment.File.FileId);
                    command.ExecuteNonQuery();

                    comment.CommentId = id;
                    comment.Date = date;
                    return comment;
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
                    command.CommandText = "DELETE FROM Comments WHERE CommentId = @CommentId";
                    command.Parameters.AddWithValue("@CommentId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Comment Get(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CommentId, Text, Date, AuthorId, FileId FROM Comments WHERE CommentId = @CommentId";
                    command.Parameters.AddWithValue("@CommentId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            return new Comment
                            {
                                CommentId = Guid.Parse(reader.GetString(reader.GetOrdinal("CommentId"))),
                                Text = reader.GetString(reader.GetOrdinal("Text")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Author = _usersRepository.Get(Guid.Parse(reader.GetString(reader.GetOrdinal("AuthorId")))),
                                File = _filesRepository.GetFileInfo(Guid.Parse(reader.GetString(reader.GetOrdinal("FileId"))))
                            };
                        }
                        throw new ArgumentException("Comment not found");
                    }
                }
            }
        }

        public void Edit(Guid id, string text)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    var Date = DateTime.Now;
                    command.CommandText = "UPDATE Comments SET Text = @Text, Date = @Date WHERE CommentId = @CommentId";
                    command.Parameters.AddWithValue("@Text", text);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@CommentId", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Comment> GetFileComments(Guid fileId)
        {
            var result = new List<Comment>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CommentId FROM Comments WHERE FileId = @FileId";
                    command.Parameters.AddWithValue("@FileId", fileId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(Get(Guid.Parse(reader.GetString(reader.GetOrdinal("CommentId")))));
                        }
                        return result;
                    }
                }
            }
        }

        public IEnumerable<Comment> GetUserComments(Guid userId)
        {
            var result = new List<Comment>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CommentId FROM Comments WHERE AuthorId = @AuthorId";
                    command.Parameters.AddWithValue("@AuthorId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(Get(Guid.Parse(reader.GetString(reader.GetOrdinal("CommentId")))));
                        }
                        return result;
                    }
                }
            }
        }
    }
}
