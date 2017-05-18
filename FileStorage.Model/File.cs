using System;
using System.Collections.Generic;

namespace FileStorage.Model
{
    public class File
    {
        public Guid FileId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        //public byte[] Content { get; set; }
        public double Size { get; set; }
        public User Owner { get; set; }

        //public virtual ICollection<User> Users { get; set; }
    }
}
