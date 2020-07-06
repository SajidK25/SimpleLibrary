using Microsoft.EntityFrameworkCore;

namespace SimpleLibrary.Book.Contexts
{
    public interface IBookContext
    {
        DbSet<Entities.Book> Books { get; set; }
    }
}