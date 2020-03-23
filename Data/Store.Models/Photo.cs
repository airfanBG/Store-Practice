namespace Store.Models
{
    using Store.Models.BaseModels;
    using System;
    public class Photo:BaseModel<string>
    {
        public string PhotoDir { get; set; }
        public string ImageType { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}