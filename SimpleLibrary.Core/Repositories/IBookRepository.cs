using System.Collections.Generic;
using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Core.Entities;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Repositories
{
    public interface IBookRepository:IRepository<Book,int,LibraryContext>
    {
    }
}