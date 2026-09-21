using Microsoft.AspNetCore.Mvc;
using CRM_IVR_API.Services;

namespace CRM_IVR_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountService _accountService;

        public AccountsController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("customer/{customerId}")]
        public async Task<IActionResult> GetAccountsByCustomerId(string customerId)
        {
            var accounts = await _accountService.GetAccountsByCustomerId(customerId);

            return Ok(accounts);
        }
    }
}