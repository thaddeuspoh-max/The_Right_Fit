namespace The_Right_Fit.Domain
{
    public class Booking : BaseDomainModel
    {
        public int ClientId { get; set; }
        public int TrainerId { get; set; }

        public DateTime SessionDateTime { get; set; }
        public int DurationMinutes { get; set; }
        public string? Status { get; set; } // "Pending", "Confirmed", "Cancelled", "Completed"
        public string? Notes { get; set; }


    }
}