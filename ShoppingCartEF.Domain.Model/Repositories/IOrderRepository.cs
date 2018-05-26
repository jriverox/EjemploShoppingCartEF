using ShoppingCartEF.Domain.Model.Entities;
using ShoppingCartEF.Domain.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartEF.Domain.Model.Repositories
{
    public interface IOrderRepository: IRepository<Order>
    {
        Task<IEnumerable<Order>> GetByParameters(OrderQueryRequest request);
    }
}
