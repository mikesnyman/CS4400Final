using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Int32 Phone { get; set; }
        public string Password { get; set; }  // I know its not set here 
    }
}