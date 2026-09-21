using Microsoft.EntityFrameworkCore;
using CRM_IVR_API.Models;

namespace CRM_IVR_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<IvrCall> IVR_Calls { get; set; }
    }
}