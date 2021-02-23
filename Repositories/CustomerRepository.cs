using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Context;
using Microsoft.EntityFrameworkCore;

namespace LiquidApi.Repositories
{
    public class CustomerRepository
    {
        private readonly LiquidApiContext _context;
        public CustomerRepository(LiquidApiContext context) 
        {
            _context = context;
        }
    

        public async Task<Models.Customer> GetCustomerByFirstAndLastName(string fistName, string LastName)
        {
            return await _context.Customers
                .FirstOrDefaultAsync( x=> (x.FirstName == fistName && x.LastName == LastName));
        }


        public async Task<Models.Customer> GetCustomerById(Guid id)
        {
            return await _context.Customers.FirstOrDefaultAsync( x => x.Id == id);
        }
    }
}
