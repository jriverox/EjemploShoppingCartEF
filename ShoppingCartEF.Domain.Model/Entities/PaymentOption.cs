using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Entities
{
    public enum PaymentOption
    {
        Cash = 0,
        BankTransfer = 1,
        CreditCard = 2,
        Bitcoin = 3,
        Ether = 4
    }
}
