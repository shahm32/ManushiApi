using ManushiApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManushiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _CS;

        public CustomerController(ICustomerService custService)
        {
            _CS = custService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var cust = _CS.GetCustomerById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpGet("GetAllCustomers")]

        public IActionResult GetAllCustomers()
        {
            return Ok(_CS.GetAllCustomers());
        }

        

    }
}
