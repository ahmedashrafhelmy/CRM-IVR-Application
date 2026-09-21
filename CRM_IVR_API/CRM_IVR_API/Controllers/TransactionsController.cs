using Microsoft.AspNetCore.Mvc;
using CRM_IVR_API.Services;

namespace CRM_IVR_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;

        public TransactionsController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("account/{accountNumber}")]
        public async Task<IActionResult> GetTransactionsByAccountNumber(
            string accountNumber)
        {
            var transactions =
                await _transactionService.GetTransactionsByAccountNumber(accountNumber);

            return Ok(transactions);
        }
    }
}