namespace The_Right_Fit.Domain
{
    public class WorkoutPlan : BaseDomainModel
    {
        // 🔐 Owner of the plan
        // null = global plan (admin/trainer)
        // not null = user-created plan
        public int? OwnerUserId { get; set; }

        // (optional assignment fields – can stay)
        public int? UserId { get; set; }

        public string? PlanName { get; set; }
        public string? GoalType { get; set; }
        public string? DifficultyLevel { get; set; }
        public int DurationWeeks { get; set; }
    }
}
