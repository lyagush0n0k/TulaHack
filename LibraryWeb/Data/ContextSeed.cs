using LibraryWeb.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace LibraryWeb.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(UserGroup.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserGroup.Librarian.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserGroup.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserGroup.None.ToString()));
        }
    }
}
