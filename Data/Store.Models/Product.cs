namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    public class Product: BaseModel<string>
    {
        public Product()
        {
            SalesOrders = new HashSet<SaleOrder>();
            Photos = new HashSet<Photo>();
        }
        [Required(ErrorMessage = "Product name is required!")]
        [MaxLength(20)]
        [MinLength(2)]
       
        public string ProductName { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        public decimal ProductPrice { get; set; }

        public int CurrentQuantity { get; set; }

        [NotMapped]//При създаване на миграция пропъртито Test няма да се добави към таблицата в базата      
        public string Test { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<SaleOrder> SalesOrders { get; set; }
    }
}
