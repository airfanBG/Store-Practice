namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Employee:BaseModel<string>
    {
        [Column("Employee_Number")]
        public string EmployeeNumber { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
