namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer:BaseModel<string>
    {
        public Customer()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
            SaleOrders = new HashSet<SaleOrder>();
        }
        [MaxLength(10)]
        [Required(ErrorMessage = "Account number is required!")]
        public string AccountNumber { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }
    }
}