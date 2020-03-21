using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Common.ViewModels
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
       
        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public int CurrentQuantity { get; set; }
    }
}
