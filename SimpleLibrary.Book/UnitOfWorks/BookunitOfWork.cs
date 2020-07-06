using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Book.Contexts;
using SimpleLibrary.Data;

namespace SimpleLibrary.Book.UnitOfWorks
{
    public class BookunitOfWork:UnitOfWork,IBookUnitOfWork
    {
        public BookunitOfWork(BookContext bookContext) 
            : base(bookContext)
        {
        }
    }
}