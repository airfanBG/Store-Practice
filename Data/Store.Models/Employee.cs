namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Employee:BaseModel<Guid>
    {
        [Column("Employee_Number")]
        public string EmployeeNumber { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Department Department { get; set; }
    }
}
