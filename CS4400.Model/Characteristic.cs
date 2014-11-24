using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class Characteristic
    {
        [Key]
        public Guid QuestionId { get; set; }
    }
}