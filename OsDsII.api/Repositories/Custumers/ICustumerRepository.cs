using OsDsII.api.Models;

namespace OsDsII.api.Repositories.Interface 
{
    public interface ICustomerReposytory
    {
        public Task<Customer> GetCustomerByIdAsync(int id);
        public Task<IEnumerable<Customer>> GetCustomerReposytoryAsync();
        
        public Task CreateCustomer(Customer customer);
    }    
}