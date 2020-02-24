namespace Store.Models.BaseModels
{
    using Store.Models.Interfaces;
    using System;

    public abstract class BaseModel<Tkey> : IAuditInfo
    {
        public Tkey Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
