using LibraryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryWeb.Pages
{
    public class BooksModel : PageModel
    {
        private readonly LibraryWeb.Data.LibraryWebContext _context;

        public BooksModel(LibraryWeb.Data.LibraryWebContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
