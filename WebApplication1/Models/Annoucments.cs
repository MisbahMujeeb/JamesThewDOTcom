//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Annoucments
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
