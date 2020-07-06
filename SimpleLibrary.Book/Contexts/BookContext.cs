using Microsoft.EntityFrameworkCore;

namespace SimpleLibrary.Book.Contexts
{
    public class BookContext:DbContext,IBookContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public BookContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        public DbSet<Entities.Book> Books { get; set; }
    }
}