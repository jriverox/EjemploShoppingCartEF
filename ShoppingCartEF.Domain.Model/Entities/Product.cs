using ShoppingCartEF.Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Entities
{
    public class Product : BaseEntity
    {
        public float Price { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
    }
}
