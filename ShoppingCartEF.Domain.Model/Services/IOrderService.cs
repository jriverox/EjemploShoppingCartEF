using ShoppingCartEF.Domain.Model.Core;
using ShoppingCartEF.Domain.Model.Entities;
using ShoppingCartEF.Domain.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF.Domain.Model.Services
{
    public interface IOrderService
    {
        Task<Order> GetById(int id);

        Task<IEnumerable<Order>> GetByParameters(OrderQueryRequest request);

        OperationResult<bool> Create(Order order);
    }
}
