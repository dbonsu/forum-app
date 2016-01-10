using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForumApp.Models.ObjectVM
{
    public class LoginVM
    {
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string UserName { get; set; }
    }
}