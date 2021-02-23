using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiquidApi.Factories;
using LiquidApi.Repositories;

namespace LiquidApi.Services
{
    public class AddressService
    {
        private readonly AddressFactory _factory;
        private readonly AddressRepository _repository;

        AddressService(AddressRepository repository, AddressFactory factory)
        {

            _repository = repository;
            _factory = factory;
        }

        public async Task<List<Controllers.Responses.Address>> GetAddressesByCountry(string country)
        {
            var addresses =  await _repository.GetAddressByCountry(country);
            return addresses.Select(x => _factory.CreateAddressResponse(x)).ToList();
        }
    }
}