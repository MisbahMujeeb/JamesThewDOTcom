using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Contests.Metadata))]
    public partial class Contests
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
            [Display(Name = "Start Date")]
            [Required]
            [DataType(DataType.Date)]
            public System.DateTime StartDate { get; set; }
            [Display(Name = "End Date")]
            [Required]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> EndDate { get; set; }
        }
        }
}