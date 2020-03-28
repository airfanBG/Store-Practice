namespace Store.Models
{
    using Microsoft.AspNetCore.Identity;
    using Store.Models.BaseModels;
    using Store.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class User : IdentityUser, IAuditInfo // BaseModel<string>
    {
        [Key]
        public override string Id { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MinLength(5)]
        [MaxLength(30)]
        public override string Email { get; set; }
       
        [MaxLength(20)]
        [Required]
        public string Telephone { get; set; } = "111-111-111";
        //One-to-one navigation property in Parent/Principal class
        public virtual Employee Employee { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
