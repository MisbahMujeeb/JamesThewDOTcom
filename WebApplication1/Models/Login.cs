using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Login
    {
        public int Id { get; set; }
        [Display(Name = "User Name")]
        [Required]
        public string User_Name { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
    }
}