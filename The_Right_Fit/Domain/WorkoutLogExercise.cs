namespace The_Right_Fit.Domain
{
    public class WorkoutLogExercise : BaseDomainModel
    {
        public int WorkoutLogId { get; set; }
        public int ExerciseId { get; set; }

        public int ActualSets { get; set; }
        public string? ActualReps { get; set; } // e.g. "12, 10, 8"



    }
}
