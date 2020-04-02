namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaleOrder : BaseModel<string>
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateOfSale { get; set; }
        [MaxLength(200)]
        public string Note { get; set; }

        public bool InternetOrdered { get; set; }
        public bool Finished { get; set; }
        public double Total { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}