using System;
using System.Collections.Generic;

namespace FileStorage.Model
{
    public class File
    {
        public Guid FileId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public double Size { get; set; }
        public User Owner { get; set; }

        public string OwnerName
        {
            get { return Owner.Name; }
        }

        public string strSize
        {
            get { return Size.ToString() + " Kb"; }
        }
    }
}
