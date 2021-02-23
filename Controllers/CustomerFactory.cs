
namespace LiquidApi.Controllers
{

    internal static class  CustomerFactory
    {
        public static Responses.Customer CreateResponseCustomer(Models.Customer customer)
        {
            return  new Responses.Customer
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EmailAddress = customer.EmailAddress
            };
        }

        public static Responses.Address CreateResponseAddress(Models.Address address)
        {
            return new Responses.Address
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