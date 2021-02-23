using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Context;
using Microsoft.EntityFrameworkCore;

namespace LiquidApi.Repositories
{
    public class AddressRepository
    {
        private readonly LiquidApiContext _context;
        public AddressRepository(LiquidApiContext context) 
        {
            _context = context;
        }

        public async Task<List<Models.Address>> GetAddressByCountry(string country)
        {
            return await _context.Addresses
                .Where(x => country.Equals(x.Country, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }
    }
}
