using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Store.Data.Common.ViewModels
{
    public class ProductViewModel
    {
        public string Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public int CurrentQuantity { get; set; }
    }
}
