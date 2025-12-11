namespace The_Right_Fit.Domain
{
    public class Exercise : BaseDomainModel
    {
        public string? ExerciseName { get; set; }
        public string? MuscleGroup { get; set; }
        public string? EquipmentNeeded { get; set; }
        public string? Instructions { get; set; }
        public string? VideoUrl { get; set; }


    }
}
