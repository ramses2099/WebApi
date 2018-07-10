using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        public string Contact_Email { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}