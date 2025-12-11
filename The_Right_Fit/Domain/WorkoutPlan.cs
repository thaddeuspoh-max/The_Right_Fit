namespace The_Right_Fit.Domain
{
    public class WorkoutPlan : BaseDomainModel
    {
        public int? UserId { get; set; }       // ❗ now nullable
        public int? TrainerId { get; set; }    // still optional

        public string? PlanName { get; set; }
        public string? GoalType { get; set; }
        public string? DifficultyLevel { get; set; }
        public int DurationWeeks { get; set; }
    }

}
