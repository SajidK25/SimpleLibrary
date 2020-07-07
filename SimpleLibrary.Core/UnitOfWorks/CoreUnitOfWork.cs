using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Core.Repositories;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.UnitOfWorks
{
    public class CoreUnitOfWork:UnitOfWork,ICoreUnitOfWork
    {
        public IBookRepository BookRepository { get; set; }
        public CoreUnitOfWork(LibraryContext libraryContext,IBookRepository bookRepository) 
            : base(libraryContext)
        {
            BookRepository = bookRepository;
        }
    }
}