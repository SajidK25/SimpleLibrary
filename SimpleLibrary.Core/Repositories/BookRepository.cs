using System.Collections.Generic;
using System.Linq;
using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Core.Entities;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Repositories
{
    public class BookRepository:Repository<Book,int,LibraryContext>,IBookRepository
    {
        private LibraryContext _libraryContext;
        public BookRepository(LibraryContext libraryContext) 
            : base(libraryContext)
        {
            _libraryContext = libraryContext;
        }
    }
}