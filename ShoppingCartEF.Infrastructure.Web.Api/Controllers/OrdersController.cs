using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartEF.Domain.Model.Services;

namespace ShoppingCartEF.Infrastructure.Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _Service;
        public OrdersController(IOrderService service)
        {
            _Service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var entity = await _Service.GetById(id);

            if (entity == null)
                return NotFound();
            return Ok(entity);
        }





    }
}