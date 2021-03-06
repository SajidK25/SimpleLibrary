using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleLibrary.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _dbContext;

        public UnitOfWork(DbContext dbContext) => _dbContext = dbContext;

        public void Dispose() => _dbContext?.Dispose();
        public void Save() => _dbContext?.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
    }
}