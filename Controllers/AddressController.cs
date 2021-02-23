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
    [Route("addresses")]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly AddressService _service;

        public AddressController(
            ILogger<AddressController> logger,
            AddressService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("{country}/searches")]
        public async Task<ActionResult<IEnumerable<Responses.Address>>> GetAddressByCountry(string country)
        {
            return await _service.GetAddressesByCountry(country);
        }
    }
}
