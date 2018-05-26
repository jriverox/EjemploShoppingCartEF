using ShoppingCartEF.Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
