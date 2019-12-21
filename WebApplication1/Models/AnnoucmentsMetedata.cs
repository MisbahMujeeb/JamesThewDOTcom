using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Annoucments.Metadata))]
    public partial class Annoucments
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
            [Display(Name = "Date of Annoucmnet")]
            [Required]
            [DataType(DataType.Date)]
            public System.DateTime Date_Of_Annoucment { get; set; }
        }
    }
}