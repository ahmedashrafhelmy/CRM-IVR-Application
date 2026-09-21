using Microsoft.EntityFrameworkCore;
using CRM_IVR_API.Data;
using CRM_IVR_API.Models;
using CRM_IVR_API.DTOs;

namespace CRM_IVR_API.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        // Get customer only
        public async Task<Customer?> GetCustomer(string customerId)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }

        // Get full customer profile
        public async Task<CustomerProfileDto?> GetCustomerProfile(string customerId)
        {
            // 1. Get customer
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);

            if (customer == null)
            {
                return null;
            }

            // 2. Get customer's accounts
            var accounts = await _context.Accounts
                .Where(a => a.CustomerId == customer.Id)
                .ToListAsync();

            // 3. Get account IDs
            var accountIds = accounts
                .Select(a => a.Id)
                .ToList();

            // 4. Get customer's transactions
            var transactions = await _context.Transactions
                .Where(t => accountIds.Contains(t.AccountId))
                .OrderByDescending(t => t.TransactionDate)
                .Take(10)
                .ToListAsync();

            // 5. Get customer's IVR calls
            var ivrCalls = await _context.IVR_Calls
                .Where(c => c.CustomerId == customer.Id)
                .OrderByDescending(c => c.CallStart)
                .ToListAsync();

            // 6. Build the final response
            return new CustomerProfileDto
            {
                Customer = customer,
                Accounts = accounts,
                RecentTransactions = transactions,
                IvrCalls = ivrCalls
            };
        }
    }
}