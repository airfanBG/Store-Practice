namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Department : BaseModel<string>
        {
            public Department()
            {
                Employees = new HashSet<Employee>();
            }
            [Required]
            [MaxLength(20)]
            [Column("Department_Name")]
            public string DepartmentName { get; set; }
            public virtual ICollection<Employee> Employees { get; set; }
        }
    
}
