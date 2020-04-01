namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Employee:BaseModel<string>
    {
        public Employee()
        {
            EmployeeCustomers = new HashSet<EmployeeCustomers>();
            SaleOrders = new HashSet<SaleOrder>();
        }
        [Column("Employee_Number")]
        public string EmployeeNumber { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public ICollection<EmployeeCustomers> EmployeeCustomers { get; set; }
        public ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
