using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.UnitOfWorks
{
    public class CoreUnitOfWork:UnitOfWork,ICoreUnitOfWork
    {
        public CoreUnitOfWork(LibraryContext libraryContext) 
            : base(libraryContext)
        {
        }
    }
}