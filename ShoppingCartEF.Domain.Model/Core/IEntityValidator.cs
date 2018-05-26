using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Core
{
    public interface IEntityValidator<TEntity> where TEntity : BaseEntity
    {
        OperationResult<bool> Validate(TEntity entity);
    }
}
