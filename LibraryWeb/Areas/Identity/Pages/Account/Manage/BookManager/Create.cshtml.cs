using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryWeb.Data;
using LibraryWeb.Models;

namespace LibraryWeb.Areas.Identity.Pages.Account.Manage.BookManager
{
    public class CreateModel : PageModel
    {
        private readonly LibraryWeb.Data.LibraryWebContext _context;

        public CreateModel(LibraryWeb.Data.LibraryWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("../BookManager");
        }
    }
}
