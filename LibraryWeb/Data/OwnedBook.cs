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
        public OwnedBook(Book book, ApplicationUser user)
        {
            this.ID = book.ID;
            this.Author = book.Author;
            this.Date = book.Date;
            this.Description = book.Description;
            this.Name = book.Name;
            this.Count = 1;
            this.Description = book.Description;
            this.Img = book.Img;
            this.Publish = book.Publish;
            this.Languages = book.Languages;
            this.OwnedUser = user;
        }
    }
}
