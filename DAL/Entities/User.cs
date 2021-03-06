﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



        public byte[] UserPhoto { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

       
    }
}
