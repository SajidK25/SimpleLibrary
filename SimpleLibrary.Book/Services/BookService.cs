using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Serilog;
using SimpleLibrary.Book.UnitOfWorks;

namespace SimpleLibrary.Book.Services
{
    public class BookService:IBookService
    {
        private IBookUnitOfWork _bookUnitOfWork;
        private readonly ILogger<BookService> _logger;
        public BookService(IBookUnitOfWork bookUnitOfWork,ILogger<BookService> logger)
        {
            _bookUnitOfWork = bookUnitOfWork;
            _logger = logger;
        }
        public IEnumerable<Entities.Book> GetBills(int pageIndex, int pageSize, string searchText, string sortText, out int total,
            out int totalFiltered)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Entities.Book> Get()
        {
            throw new System.NotImplementedException();
        }

        public void AddNewBook(Entities.Book book)
        {
            throw new System.NotImplementedException();
        }

        public Entities.Book GetBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public void EditBook(Entities.Book book)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}