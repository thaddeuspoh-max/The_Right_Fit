using Microsoft.AspNetCore.Identity;

namespace The_Right_Fit.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class The_Right_FitUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public double? HeightCm { get; set; }
        public double? WeightKg { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? GoalType { get; set; }
    }

}
