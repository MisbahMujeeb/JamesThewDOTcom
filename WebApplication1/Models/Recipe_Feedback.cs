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
    
    public partial class Recipe_Feedback
    {
        public int Id { get; set; }
        public string RecipeFeedback { get; set; }
        public int RecipesId { get; set; }
        public int UsersId { get; set; }
    
        public virtual Recipes Recipe { get; set; }
        public virtual Users User { get; set; }
    }
}
