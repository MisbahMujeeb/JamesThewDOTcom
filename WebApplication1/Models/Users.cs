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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Participants = new HashSet<Participants>();
            this.Feedbacks = new HashSet<Feedbacks>();
            this.Recipes = new HashSet<Recipes>();
            this.Tips = new HashSet<Tips>();
        }
    
        public int Id { get; set; }
        [Display(Name ="User Name")]
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
    
        public virtual Role Role { get; set; }
        public virtual Subscription_Type Subscription_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participants> Participants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedbacks> Feedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipes> Recipes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tips> Tips { get; set; }
    }
}