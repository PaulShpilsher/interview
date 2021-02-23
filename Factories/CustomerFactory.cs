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
    }
}