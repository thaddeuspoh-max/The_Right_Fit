using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using The_Right_Fit.Data;

namespace The_Right_Fit.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<The_Right_FitUser>
    {
        public void Configure(EntityTypeBuilder<The_Right_FitUser> builder)
        {
            var hasher = new PasswordHasher<The_Right_FitUser>();

            builder.HasData(
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
                new The_Right_FitUser
                {
                    Id = "99999999-8888-7777-6666-555555555555",
                    Email = "user@therightfit.com",
                    NormalizedEmail = "USER@THERIGHTFIT.COM",

                    FirstName = "Jane",
                    LastName = "User",

                    UserName = "user@therightfit.com",
                    NormalizedUserName = "USER@THERIGHTFIT.COM",

                    PasswordHash = hasher.HashPassword(null, "User123!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
