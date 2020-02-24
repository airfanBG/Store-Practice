namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;

    public class EmployeeCustomers: BaseModel<Guid>
    {
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}