using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Core.Repositories;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.UnitOfWorks
{
    public interface ICoreUnitOfWork:IUnitOfWork
    {
        IBookRepository BookRepository { get; set; }
    }
}