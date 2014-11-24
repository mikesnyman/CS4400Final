using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class UserAnswer
    {
        [Key]
        public Guid UserId { get; set; }
        [Key]
        public Guid QuestionId { get; set; }

        public string Answer { get; set; }
        public Guid StudyId { get; set; }
    }
}