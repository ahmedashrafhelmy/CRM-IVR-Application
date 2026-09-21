using Microsoft.EntityFrameworkCore;
using CRM_IVR_API.Data;
using CRM_IVR_API.Models;

namespace CRM_IVR_API.Services
{
    public class IvrCallService
    {
        private readonly AppDbContext _context;

        public IvrCallService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<IvrCall>> GetCallsByCustomerId(string customerId)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);

            if (customer == null)
            {
                return new List<IvrCall>();
            }

            return await _context.IVR_Calls
                .Where(c => c.CustomerId == customer.Id)
                .OrderByDescending(c => c.CallStart)
                .ToListAsync();
        }
    }
}