using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace CS4400.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        //public DbSet<UserProfile> UserProfiles { get; set; }
    }
    public class RegisterUserViewModel
    {
        public string ReturnUrl { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginUserViewModel
    {
        public string ReturnUrl { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class QuestionViewModel
    {
        [Required]
        public string Question { get; set; }
        public string PotentialAns1 { get; set; }
        public string PotentialAns2 { get; set; }
        public string PotentialAns3 { get; set; }
        public string PotentialAns4 { get; set; }
        public bool Answer { get; set; }
    }

    public class LocalPasswordModel
    {

    }
}
