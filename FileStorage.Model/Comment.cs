using System;

namespace FileStorage.Model
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; } 
        public User Author { get; set; }
        public File File { get; set; }

        public string AuthorName
        {
            get { return Author.Name; }
        }
    }
}
