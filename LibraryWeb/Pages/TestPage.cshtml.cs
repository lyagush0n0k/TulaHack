using LibraryWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LibraryWeb.Pages
{
    public class TestPageModel : PageModel
    {
        private readonly LibraryWeb.Data.ApplicationDbContext _context;
        public ApplicationUser currentUserId;
        public string ID;

        public TestPageModel(LibraryWeb.Data.ApplicationDbContext context)
        {
            _context = context;
            
        }

        public async Task OnGetAsync()
        {
            currentUserId = _context.Users.FirstOrDefault(u => u.Id == ID);
        }
    }
}
