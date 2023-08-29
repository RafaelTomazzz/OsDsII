using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OsDsII.api.Models;

namespace OsDsII.api.Services.Customers
{
    public class CustomersService(ICustomersService service)
    {
        

        public async Task <Customer> CreateCustomerAsync(Customer customer)
        {
            Customer currentCustomer = await _customersRepository.GetCustomerByIdAsync( customer.Id );
            if ( currentCustomer != null && currentCustomer.Equals( customer ))
            {
                throw new Exception( "customer alredy exists" );
            }
            await _customersRepository.CreateCustomerAsync(customer);
            return currentCustomer; 
        }

    
    }


}