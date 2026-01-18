using System.ComponentModel.DataAnnotations;

namespace The_Right_Fit.Domain
{
    public class UserActivePlan
    {
        public int Id { get; set; }

        [Required]
        public string OwnerIdentityUserId { get; set; } = "";

        public int WorkoutPlanId { get; set; }

        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }
}
