using Microsoft.AspNetCore.Mvc;
using CRM_IVR_API.Services;

namespace CRM_IVR_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IvrCallsController : ControllerBase
    {
        private readonly IvrCallService _ivrCallService;

        public IvrCallsController(IvrCallService ivrCallService)
        {
            _ivrCallService = ivrCallService;
        }

        [HttpGet("customer/{customerId}")]
        public async Task<IActionResult> GetCallsByCustomerId(string customerId)
        {
            var calls = await _ivrCallService.GetCallsByCustomerId(customerId);

            return Ok(calls);
        }
    }
}