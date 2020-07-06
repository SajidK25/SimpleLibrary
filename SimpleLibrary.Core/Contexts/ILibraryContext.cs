using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Core.Entities;

namespace SimpleLibrary.Core.Contexts
{
    public interface ILibraryContext
    {
        DbSet<Entities.Book> Books { get; set; }
        DbSet<Borrower> Borrowers { get; set; }
        DbSet<BookIssue> BookIssues { get; set; }
        DbSet<ReturnBook> ReturnBooks { get; set; }

    }
}