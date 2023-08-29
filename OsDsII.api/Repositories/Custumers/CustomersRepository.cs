using Microsoft.EntityFrameworkCore;
using OsDsII.api.data;
using OsDsII.api.Models;
using OsDsII.api.Repositories.Interfaces;

namespace Repositories.Custumers 
{
    public class CustomersRepository : ICustomerReposytory
    {
        private readonly DataContext _context;

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
        {
            IEnumerable<Customer> customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customer> CustomerCreateAysnc(Customer customer)
        {
            await _context.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

    }
}