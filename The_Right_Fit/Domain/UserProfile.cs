namespace The_Right_Fit.Domain
{
    public class UserProfile : BaseDomainModel
    {
        public int UserId { get; set; }

        public double HeightCm { get; set; }
        public double WeightKg { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


        public string? GoalType { get; set; }


    }
}