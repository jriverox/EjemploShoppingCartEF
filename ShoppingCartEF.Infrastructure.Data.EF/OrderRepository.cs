using ShoppingCartEF.Domain.Model.Entities;
using ShoppingCartEF.Domain.Model.Repositories;
using ShoppingCartEF.Domain.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ShoppingCartEF.Infrastructure.Data.EF
{
    public class OrderRepository : RepositoryBase, IOrderRepository
    {
        public OrderRepository(ShoppingCartDbContext db):base(db)
        {

        }
        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> Get(int id)
        {
            return await _db.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetByParameters(OrderQueryRequest request)
        {
            var query = _db.Orders.AsQueryable();

            if (request.CustomerId.HasValue && request.CustomerId.Value > 0)
                query = query.Where(x => x.CustomerId == request.CustomerId.Value);

            if (request.PaymentOption.HasValue)
                query = query.Where(x => x.PaymentOption == request.PaymentOption.Value);

            if (request.Start.HasValue && request.End.HasValue && request.Start.Value < request.End.Value)
                query = query.Where(x => x.Date >= request.Start.Value && x.Date <= request.End.Value);

            if (request.PageSize == 0)
                request.PageSize = 10;

            query = query.Skip(request.StartRowIndex).Take(request.PageSize);

            return await query.ToListAsync();
        }

        public void Insert(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Order entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
