using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using SimpleLibrary.Core.Entities;
using SimpleLibrary.Core.UnitOfWorks;

namespace SimpleLibrary.Core.Services
{
    public class BookService:IBookService
    {
        private ICoreUnitOfWork _coreUnitOfWork;
        private readonly ILogger<BookService> _logger;
        public BookService(ICoreUnitOfWork coreUnitOfWork,ILogger<BookService> logger)
        {
            _coreUnitOfWork = coreUnitOfWork;
            _logger = logger;
        }
        public IEnumerable<Book> GetBooks(
            int pageIndex, 
            int pageSize, 
            string searchText, 
            string sortText, 
            out int total,
            out int totalFiltered)
        {
            
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> Get()
        {
            return _coreUnitOfWork.BookRepository.GetAll();
        }

        public void AddNewBook(Book book)
        {
            _coreUnitOfWork.BookRepository.Add(book);
        }

        public Book GetBook(int id)
        {
            return _coreUnitOfWork.BookRepository.GetById(id);
        }

        public void EditBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}