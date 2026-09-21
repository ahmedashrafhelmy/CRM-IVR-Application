using CRM_IVR_API.Models;

namespace CRM_IVR_API.DTOs
{
    public class CustomerProfileDto
    {
        public Customer? Customer { get; set; }

        public List<Account> Accounts { get; set; } = new();

        public List<Transaction> RecentTransactions { get; set; } = new();

        public List<IvrCall> IvrCalls { get; set; } = new();
    }
}