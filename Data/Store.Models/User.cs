namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class User : BaseModel<string>
    {
        [Required(ErrorMessage = "Email is required")]
        [MinLength(5)]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(20)]
        [Required]
        public string Telephone { get; set; } = "111-111-111";
        //One-to-one navigation property in Parent/Principal class
        public virtual Employee Employee { get; set; }
    }
}
