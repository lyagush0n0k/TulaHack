using LibraryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryWeb.Pages;

public class BookPage : PageModel
{
    private readonly LibraryWeb.Data.LibraryWebContext _context;

    [BindProperty(SupportsGet = true)]
    public uint Id { get; set; }
    public Book Book { get; set; }
    public BookPage(LibraryWeb.Data.LibraryWebContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Book = _context.Book.Find(Id);
    }
}