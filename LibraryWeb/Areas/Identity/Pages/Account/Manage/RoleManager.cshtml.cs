using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Data;
using LibraryWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace LibraryWeb.Areas.Identity.Pages.Account.Manage
{
    public class RoleManagerModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public IList<ApplicationUser> users { get; set; }
        public List<UserRolesViewModel> userRolesViewModel { get; set; }
        public RoleManagerModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task OnGetAsync()
        {
            users = await _userManager.Users.ToListAsync();
            userRolesViewModel = new List<UserRolesViewModel>();

            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModel.Add(thisViewModel);
            }
        }
        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }
    }
}
