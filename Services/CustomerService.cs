using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Factories;
using LiquidApi.Repositories;

namespace LiquidApi.Services
{
    public class CustomerService
    {
        private readonly CustomerFactory _factory;
        private readonly CustomerRepository _repository;

        public CustomerService(CustomerRepository repository, CustomerFactory factory)
        {
            _repository = repository;

            _factory = factory;
        }


        public async Task<Controllers.Responses.Customer> GetCustomerByFirstAndLastName(string firstName, string lastName)
        {
            var customer =  await _repository.GetCustomerByFirstAndLastName(firstName, lastName);
            return customer == null ? null : _factory.CreateCustomerResponse(customer);
        }
    }

}