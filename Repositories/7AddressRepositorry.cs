using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Context;

namespace LiquidApi.Repositories
{
    public class AddressRepository
    {
        private readonly LiquidApiContext _context;
        public AddressRepository(LiquidApiContext context) 
        {
            _context = context;
        }

        public List<Models.Address> GetAddressByCountry(string country)
        {
            var addresses = _context.Addresses.Where(x => x.Country == country);
            if(addresses.Any())
            {
                return addresses.ToList();
            }
            else
            {
                return new List<Models.Address>(0);
            }
            
        }
    }
}
