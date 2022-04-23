using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryWeb.Models;

namespace LibraryWeb.Data
{
    public class LibraryWebContext : DbContext
    {
        public LibraryWebContext (DbContextOptions<LibraryWebContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryWeb.Models.Book> Book { get; set; }
    }
}
