using Microsoft.EntityFrameworkCore;
using CRM_IVR_API.Data;
using CRM_IVR_API.Models;

namespace CRM_IVR_API.Services
{
    public class AccountService
    {
        private readonly AppDbContext _context;

        public AccountService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Account>> GetAccountsByCustomerId(string customerId)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);

            if (customer == null)
            {
                return new List<Account>();
            }

            return await _context.Accounts
                .Where(a => a.CustomerId == customer.Id)
                .ToListAsync();
        }
    }
}