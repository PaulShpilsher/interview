using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Factories;
using LiquidApi.Repositories;

namespace LiquidApi.Services
{
    public class CustomerService
    {
        private readonly CustomerFactory _customerFactory;
        private readonly CustomerRepository _customerRepository;
        private readonly AddressRepository _addressRepository;

        public CustomerService(CustomerRepository customerRepository, AddressRepository addressRepository, CustomerFactory customerFactory)
        {
            _customerRepository = customerRepository;
            _addressRepository = addressRepository;
            _customerFactory = customerFactory;
        }

        public async Task<List<Controllers.Responses.Address>> GetAddressesByCountry(string country)
        {
            var addresses =  await _addressRepository.GetAddressByCountry(country);
            return addresses.Select(x => _customerFactory.CreateAddressResponse(x)).ToList();
        }


        public async Task<Controllers.Responses.Customer> GetCustomerByFirstAndLastName(string firstName, string lastName)
        {
            var customer =  await _customerRepository.GetCustomerByFirstAndLastName(firstName, lastName);
            return customer == null ? null : _customerFactory.CreateCustomerResponse(customer);
        }
    }
}