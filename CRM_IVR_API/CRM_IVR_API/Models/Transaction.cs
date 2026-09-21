namespace CRM_IVR_API.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string TransactionId { get; set; } = "";

        public int AccountId { get; set; }

        public string TransactionType { get; set; } = "";

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Status { get; set; } = "";
    }
}