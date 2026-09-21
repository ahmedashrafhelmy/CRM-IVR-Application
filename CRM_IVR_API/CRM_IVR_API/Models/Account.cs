namespace CRM_IVR_API.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; } = "";

        public int CustomerId { get; set; }

        public string AccountType { get; set; } = "";

        public decimal Balance { get; set; }

        public string Currency { get; set; } = "";

        public string Status { get; set; } = "";
    }
}