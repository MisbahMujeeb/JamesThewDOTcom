using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Recipes.Metadata))]
    public partial class Recipes
    {
        sealed class Metadata
        {
            public int Id { get; set; }
            [Display(Name = "Title")]
            [Required]
            public string Title { get; set; }
            [Display(Name = "Ingredients")]
            [Required]
            [DataType(DataType.MultilineText)]
            public string Ingridiants { get; set; }
            [Display(Name = "Details")]
            [Required]
            [DataType(DataType.MultilineText)]
            public string Details { get; set; }
            public int UsersId { get; set; }
            public string ImagePath { get; set; }
            //public HttpPostedFileBase ImageFile { get; set; }
            public HttpPostedFileBase ImageFile { get; set; }
            public string FreeOrPaid { get; set; }
        }
    }
}