using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }  

        public string Name { get; set; }
        public string Email { get; set; }
        public Int32 Phone { get; set; }

    }
}