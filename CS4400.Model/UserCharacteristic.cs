using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class UserCharacteristic
    {
        [Key]
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        [Required]
        public Guid UsersAnswer { get; set; }
    }
}