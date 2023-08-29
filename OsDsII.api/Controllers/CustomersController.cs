using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using OsDsII.api.Data;
using OsDsII.api.Models;

namespace OsDsII.api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ICustomersService _customersRepository;

        public CustomersController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                IEnumerable<Customer> lista = await _context.Customers.GetAllCustomerAsync();
                return Ok(lista);
            }

            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                Customer a = await _context.Customers.FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                return Ok(a);   
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateCustumer([FromBody]Customer novoCustomer)
        {
            try
            {
                Customer currentCustumer = await _context.CustomersService.CreateCustomerAsync(customer);
                
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Customer cRemover = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);

                _context.Customers.Remove(cRemover);
                int linhaAfetadas = await _context.Customers.CountAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}