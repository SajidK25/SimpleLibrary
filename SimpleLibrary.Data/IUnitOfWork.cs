using System.Threading.Tasks;

namespace SimpleLibrary.Data
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}