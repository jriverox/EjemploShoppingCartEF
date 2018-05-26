using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Infrastructure.Data.EF
{
    public abstract class RepositoryBase
    {
        protected readonly ShoppingCartDbContext _db;
        protected RepositoryBase(ShoppingCartDbContext db)
        {
            _db = db;
        }
    }
}
