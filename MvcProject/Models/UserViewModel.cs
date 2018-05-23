using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProject.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display (Name = "Login")]
        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] UserPhoto { get; set; }

       
    }
}