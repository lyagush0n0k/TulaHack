using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Data;
using LibraryWeb.Models;

namespace LibraryWeb.Areas.Identity.Pages.Account.Manage.BookManager
{
    public class DetailsModel : PageModel
    {
        private readonly LibraryWeb.Data.LibraryWebContext _context;

        public DetailsModel(LibraryWeb.Data.LibraryWebContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
