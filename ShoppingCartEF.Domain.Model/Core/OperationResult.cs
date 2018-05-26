using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Core
{
    public class OperationResult<TValue>
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public int TotalRowsCount { get; set; }
        public TValue Value { get; set; }
    }
}
