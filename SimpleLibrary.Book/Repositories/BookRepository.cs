using System.Collections.Generic;
using System.Linq;
using SimpleLibrary.Book.Contexts;
using SimpleLibrary.Data;

namespace SimpleLibrary.Book.Repositories
{
    public class BookRepository:Repository<Entities.Book,int,BookContext>,IBookRepository
    {
        private BookContext _bookContext;
        public BookRepository(BookContext bookContext) 
            : base(bookContext)
        {
            _bookContext = _bookContext;
        }

        public IEnumerable<Entities.Book> GetAllBooks()
        {
            return _bookContext.Books.ToList();
        }
    }
}