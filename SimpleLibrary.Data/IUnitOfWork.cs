using System;
using System.Threading.Tasks;

namespace SimpleLibrary.Data
{
    public interface IUnitOfWork:IDisposable 
    {
        void Save();
        Task SaveAsync();
    }
}