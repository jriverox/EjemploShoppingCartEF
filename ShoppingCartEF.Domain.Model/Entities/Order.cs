using ShoppingCartEF.Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Entities
{
    public class Order: BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public DateTime? Date { get; set; }
    }
}
