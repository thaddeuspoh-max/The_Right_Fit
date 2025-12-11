namespace The_Right_Fit.Domain
{
    public class WorkoutPlanExercise : BaseDomainModel
    {
        public int WorkoutPlanId { get; set; }
        public int ExerciseId { get; set; }

        public int DayOfWeek { get; set; }     // 1–7 (Mon–Sun)

        public int Sets { get; set; }
        public int Reps { get; set; }



    }
}