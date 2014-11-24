using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    [Serializable]
    public class Study
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid ResearcherId { get; set; }
    }
}