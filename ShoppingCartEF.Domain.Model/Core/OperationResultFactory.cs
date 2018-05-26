using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Core
{
    public static class OperationResultFactory
    {
        public static OperationResult<TValue> CreateOK<TValue>(TValue value)
        {
            return new OperationResult<TValue> { Value = value, Success = true };
        }

        public static OperationResult<TValue> CreateFail<TValue>(TValue value, string error)
        {
            var errors = new List<string>
            {
                error
            };
            return CreateFail(value, errors);
        }

        public static OperationResult<TValue> CreateFail<TValue>(TValue value, List<string> errors)
        {
            return new OperationResult<TValue> { Value = value, Success = false, Errors = errors };
        }
    }
}
