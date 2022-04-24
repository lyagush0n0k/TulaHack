using LibraryWeb.Data;
using LibraryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibraryWeb.Areas.Identity.Pages.Account.Manage.UserManager
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryWeb.Data.ApplicationDbContext _context;

        public DetailsModel(LibraryWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser User { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
