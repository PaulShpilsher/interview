using LiquidApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiquidApi.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly CustomerService _service;

        public CustomerController(
            ILogger<CustomerController> logger,
            CustomerService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("searches")]
        public async Task<ActionResult<Responses.Customer>> GetCustomerByFirstAndLastName(Requests.CustomerByFirstAndLastName req)
        {
            if(req == null)
            {
                return BadRequest();
            }

            var customer = await _service.GetCustomerByFirstAndLastName(req.FirstName, req.LastName);
            if(customer == null)
            {
                return NoContent();
            }

            return customer;
        }

        [HttpGet("addresses/{country}/searches")]
        public async Task<ActionResult<IEnumerable<Responses.Address>>> GetAddressByCountry(string country)
        {
            return await _service.GetAddressesByCountry(country);
        }
    }
}
