using ShoppingCartEF.Domain.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Entities
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }
}
