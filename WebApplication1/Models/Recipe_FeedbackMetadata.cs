using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Recipe_Feedback.Metadata))]
    public partial class Recipe_Feedback
    {
        sealed class Metadata
        {
            public int Id { get; set; }
            [Display(Name = "Feedback")]
            [Required]
            public string RecipeFeedback { get; set; }
            public int RecipesId { get; set; }
            public int UsersId { get; set; }
        }
    }
}