namespace The_Right_Fit.Domain
{
    public class WorkoutLog : BaseDomainModel
    {
        public int UserId { get; set; }
        public int? WorkoutPlanId { get; set; }

        public DateTime WorkoutDateTime { get; set; }
        public int DurationMinutes { get; set; }
        public string? Notes { get; set; }


    }
}
