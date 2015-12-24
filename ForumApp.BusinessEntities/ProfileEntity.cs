using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class ProfileEntity
    {
        public byte[] Avatar { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public long ID { get; set; }
        public string Interests { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int PostCount { get; set; }
        public virtual UserEntity User { get; set; }
        public long UserID { get; set; }
    }
}