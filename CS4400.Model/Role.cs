using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class Role
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string RoleType { get; set; } //Admin, Researcher, Teacher, Participant
    }
}