using ShoppingCartEF.Domain.Model.Core;
using ShoppingCartEF.Domain.Model.Entities;
using ShoppingCartEF.Domain.Model.Repositories;
using ShoppingCartEF.Domain.Model.Requests;
using ShoppingCartEF.Domain.Model.Services;
using ShoppingCartEF.Domain.Services.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF.Domain.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _Repository;

        public OrderService(IOrderRepository repository)
        {
            _Repository = repository;
        }

        public OperationResult<bool> Create(Order order)
        {
            var validator = new OrderCreationValidator();
            var result = validator.Validate(order);
            if (result.Success)
            {
                _Repository.Insert(order);
                _Repository.SaveChanges();
            }
            return result;
        }

        public async Task<Order> GetById(int id)
        {
            return await _Repository.Get(id);
        }

        public async Task<IEnumerable<Order>> GetByParameters(OrderQueryRequest request)
        {
            return await _Repository.GetByParameters(request);
        }
    }
}
