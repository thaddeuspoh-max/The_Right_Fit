using The_Right_Fit.Data;
using Microsoft.AspNetCore.Identity;

namespace The_Right_Fit.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<The_Right_FitUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<The_Right_FitUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
