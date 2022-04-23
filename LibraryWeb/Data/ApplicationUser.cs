using LibraryWeb.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace LibraryWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public List<Book> Books { get; set; }
    }
}
