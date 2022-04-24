using LibraryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryWeb.Areas.Identity.Pages.Account.Manage
{
    public class UsersModel : PageModel
    {
        private readonly LibraryWeb.Data.ApplicationDbContext _context;

        public UsersModel(LibraryWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ApplicationUser> User { get; set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
