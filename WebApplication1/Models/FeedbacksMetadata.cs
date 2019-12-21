using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(Feedbacks.Metadata))]
    public partial class Feedbacks
    {
        sealed class Metadata { 
        public int Id { get; set; }
        public int UsersId { get; set; }
        [Display(Name = "Feedback")]
        [DataType(DataType.MultilineText)]
        public string Feedback { get; set; }
        }
    }
}