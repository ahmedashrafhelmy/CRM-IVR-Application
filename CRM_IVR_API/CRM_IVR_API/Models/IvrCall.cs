namespace CRM_IVR_API.Models
{
    public class IvrCall
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime CallStart { get; set; }

        public DateTime? CallEnd { get; set; }

        public string CallStatus { get; set; } = "";

        public string? SelectedOption { get; set; }
    }
}