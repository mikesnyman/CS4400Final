using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class UserStudy
    {
        [Key]
        public Guid UserId { get; set; }
        [Key]
        public Guid StudyId { get; set; }
    }
}