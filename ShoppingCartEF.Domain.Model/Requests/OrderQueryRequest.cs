using ShoppingCartEF.Domain.Model.Core;
using ShoppingCartEF.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Requests
{
    public class OrderQueryRequest: QueryRequest
    {
        public int? CustomerId { get; set; }
        public PaymentOption? PaymentOption { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
