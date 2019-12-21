using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Tips.Metadata))]
    public partial class Tips
    {
        sealed class Metadata
        {
            public int Id { get; set; }
            [Display(Name = "Title")]
            [Required]
            public string Title { get; set; }
            [Display(Name = "Details")]
            [Required]
            [DataType(DataType.MultilineText)]
            public string Details { get; set; }
            public int UsersId { get; set; }
        }
        }
}