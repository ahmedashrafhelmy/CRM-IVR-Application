namespace CRM_IVR_API.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerId { get; set; } = "";

        public string FullName { get; set; } = "";

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}