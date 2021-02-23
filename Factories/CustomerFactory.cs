using LiquidApi.Controllers.Responses;

namespace LiquidApi.Factories
{
    public class  CustomerFactory
    {
        public Customer CreateCustomerResponse(Models.Customer customer)
        {
            return new Customer
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EmailAddress = customer.EmailAddress
            };
        }

        public Address CreateAddressResponse(Models.Address address)
        {
            return new Address
            {
                Id = address.Id,
                Line1 = address.Line1,
                Line2 = address.Line2,
                City = address.City,
                StateOrProvince = address.StateOrProvince,
                Country = address.Country,
                PostalCode = address.PostalCode
            };
        }
    }
}