using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Data;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<The_Right_FitUser>
    {
        public void Configure(EntityTypeBuilder<The_Right_FitUser> builder)
        {
            var hasher = new PasswordHasher<The_Right_FitUser>();

            builder.HasData(

                // ============================
                // ADMIN USER
                // ============================
                new The_Right_FitUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@therightfit.com",
                    NormalizedEmail = "ADMIN@THERIGHTFIT.COM",

                    FirstName = "Admin",
                    LastName = "User",

                    UserName = "admin@therightfit.com",
                    NormalizedUserName = "ADMIN@THERIGHTFIT.COM",

                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true
                },

                // ============================
                // TRAINER USER
                // ============================
                new The_Right_FitUser
                {
                    Id = "ee111111-2222-3333-4444-555555555555",
                    Email = "trainer@therightfit.com",
                    NormalizedEmail = "TRAINER@THERIGHTFIT.COM",

                    FirstName = "John",
                    LastName = "Trainer",

                    UserName = "trainer@therightfit.com",
                    NormalizedUserName = "TRAINER@THERIGHTFIT.COM",

                    PasswordHash = hasher.HashPassword(null, "Trainer123!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
