using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Users.Metadata))]
    public partial class Users
    {
        sealed class Metadata
        {
            public int Id { get; set; }
            [Display(Name = "User Name")]
            [Required]
            public string User_Name { get; set; }
            [Display(Name = "Email")]
            [Required]
            public string Email { get; set; }
            [Display(Name = "Password")]
            [Required]
            public string Password { get; set; }
            [Display(Name = "Role")]
            [Required]
            public int Role_id { get; set; }
            [Display(Name = "Subscription Type")]
            [Required]
            public int Subscription_Type_id { get; set; }
        }
        }
}