using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Role.Metadata))]
    public partial class Role
    {
        sealed class Metadata
        {
            public int id { get; set; }
            [Display(Name = "Role")]
            [Required]
            public string Role_name { get; set; }
        }
        }
}