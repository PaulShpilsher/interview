using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Context;

namespace LiquidApi.Repositories
{
    public class CustomerRepository
    {
        private readonly LiquidApiContext _context;
        public CustomerRepository(LiquidApiContext context) 
        {
            _context = context;
        }
    

        public Models.Customer GetCustomerByFirstAndLastName(string fistName, string LastName)
        {
            return _context.Customers.FirstOrDefault( x=> (x.FirstName == fistName && x.LastName == LastName));
        }


        public Models.Customer GetCustomerById(Guid id)
        {
            return _context.Customers.FirstOrDefault( x=> x.Id == id);
        }
    }
}
