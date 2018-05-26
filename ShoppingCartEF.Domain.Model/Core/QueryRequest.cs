using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Core
{
    public class QueryRequest
    {
        public int StartRowIndex { get; set; }
        public int PageSize { get; set; }
    }
}
