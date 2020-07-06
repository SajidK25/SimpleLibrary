using System.Collections.Generic;

namespace SimpleLibrary.Book.Services
{
    public interface IBookService
    {
        IEnumerable<Entities.Book> GetBills(
            int pageIndex,
            int pageSize,
            string searchText,
            string sortText,
            out int total,
            out int totalFiltered);
        
        IEnumerable<Entities.Book> Get();
        void AddNewBook(Entities.Book book);
        Entities.Book GetBook(int id);
        void EditBook(Entities.Book book);
        void DeleteBook(int id);
    }
}