using System.Collections.Generic;
using SimpleLibrary.Book.Contexts;
using SimpleLibrary.Data;

namespace SimpleLibrary.Book.Repositories
{
    public interface IBookRepository:IRepository<Entities.Book,int,BookContext>
    {
        IEnumerable<Entities.Book> GetAllBooks();
    }
}