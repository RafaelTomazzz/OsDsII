using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsDsII.api.Services.Customers
{
    public class ICustomersService
    {
        public Task<IEnumerable<Customer>> GetCustomerReposytoryAsync();
        public Task CreateCustomerAsync(Customer customer);
        
    }
}