using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class Question
    {
        [Key]
        public Guid Id { get; set; }
        public Guid StudyId { get; set; }
        [Required]
        public string theQuestion { get; set; }
        [Required]
        public string correctAnswer { get; set; }
        public string possAnswer1 { get; set; }
        public string possAnswer2 { get; set; }
        public string possAnswer3 { get; set; }
        public string possAnswer4 { get; set; }
        public string possAnswer5 { get; set; }
        public string possAnswer6 { get; set; }

    }
}