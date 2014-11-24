using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class UserRole
    {
        [Key]
        public Guid UserId { get; set; }
        [Key]
        public Guid RoleId { get; set; }
    }
}