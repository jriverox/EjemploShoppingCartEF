using ShoppingCartEF.Domain.Model.Core;
using ShoppingCartEF.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Services.Orders
{
    public class OrderCreationValidator : IEntityValidator<Order>
    {
        public OperationResult<bool> Validate(Order entity)
        {
            if (entity == null)
                return OperationResultFactory.CreateFail(false, "No se puede crear la entidad desde una instancia nula.");
            if (entity.CustomerId < 1)
                return OperationResultFactory.CreateFail(false, "No se puede crear la entidad sin especificar un cliente.");
            

            return OperationResultFactory.CreateOK(true);
        }
    }
}
