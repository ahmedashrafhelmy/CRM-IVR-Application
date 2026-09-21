using Microsoft.EntityFrameworkCore;
using CRM_IVR_API.Data;
using CRM_IVR_API.Models;

namespace CRM_IVR_API.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _context;

        public TransactionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Transaction>> GetTransactionsByAccountNumber(
            string accountNumber)
        {
            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.AccountNumber == accountNumber);

            if (account == null)
            {
                return new List<Transaction>();
            }

            return await _context.Transactions
                .Where(t => t.AccountId == account.Id)
                .OrderByDescending(t => t.TransactionDate)
                .ToListAsync();
        }
    }
}