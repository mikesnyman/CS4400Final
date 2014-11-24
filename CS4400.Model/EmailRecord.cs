using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CS4400.Model
{
    public class EmailRecord
    {
        public EmailRecord()
            : base()
        {
            DateUTC = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }
        public string FromAddress { get; set; }
        public string RecipientAddresses { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateUTC { get; set; }
    }
}