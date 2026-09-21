using Microsoft.AspNetCore.Mvc;
using CRM_IVR_API.Services;

namespace CRM_IVR_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        // Get customer basic information
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(string id)
        {
            var customer = await _customerService.GetCustomer(id);

            if (customer == null)
            {
                return NotFound(new
                {
                    message = "Customer not found"
                });
            }

            return Ok(customer);
        }

        // Get full customer profile
        [HttpGet("{id}/profile")]
        public async Task<IActionResult> GetCustomerProfile(string id)
        {
            var profile = await _customerService.GetCustomerProfile(id);

            if (profile == null)
            {
                return NotFound(new
                {
                    message = "Customer not found"
                });
            }

            return Ok(profile);
        }
    }
}