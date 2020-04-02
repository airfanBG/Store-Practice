using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Common.ViewModels
{
    public class OrderViewModel
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
