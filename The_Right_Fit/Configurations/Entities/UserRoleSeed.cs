using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace The_Right_Fit.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                // ADMIN → Administrator role
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },

                // TRAINER → Trainer role
                new IdentityUserRole<string>
                {
                    RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518cc",
                    UserId = "ee111111-2222-3333-4444-555555555555"
                }
            );
        }
    }
}
