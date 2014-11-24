using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class Answer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string theAnswer { get; set; }
        //public string AnswerA { get; set; }
        //public string AnswerB { get; set; }
        //public string AnswerC { get; set; }
        //public string AnswerD { get; set; }
        //public string AnswerTrue { get; set; }
        //public string AnswerFalse { get; set; }
    }
}