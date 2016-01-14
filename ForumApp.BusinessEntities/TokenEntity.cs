﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities
{
    public class TokenEntity
    {
        public string AuthToken { get; set; }
        public System.DateTime ExpiresOn { get; set; }
        public long ID { get; set; }
        public System.DateTime IssuedOn { get; set; }
        public virtual UserEntity User { get; set; }
        public long UserID { get; set; }
    }
}