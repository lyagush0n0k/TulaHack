using LibraryWeb.Models;
using LibraryWeb.Data;

namespace LibraryWeb.Data
{
    public class OwnedBook : Book
    {
        public ApplicationUser OwnedUser { get; set; }

        public OwnedBook()
        {
            Count = 0;
        }
    }
}
