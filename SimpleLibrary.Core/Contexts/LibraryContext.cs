using Microsoft.EntityFrameworkCore;
using SimpleLibrary.Core.Entities;

namespace SimpleLibrary.Core.Contexts
{
    public class LibraryContext:DbContext,ILibraryContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public LibraryContext(string connectionString, string migrationAssemblyName)
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookIssue>()
                .HasKey(bc => new {bc.BookId, bc.BorrowerId});
            modelBuilder.Entity<BookIssue>()
                .HasOne(bi => bi.Book)
                .WithMany(b => b.BookIssues)
                .HasForeignKey(bi => bi.BookId);
            modelBuilder.Entity<BookIssue>()
                .HasOne(bc => bc.Borrower)
                .WithMany(br => br.BookIssues)
                .HasForeignKey(bi=>bi.BorrowerId);

            modelBuilder.Entity<ReturnBook>()
                .HasKey(rb => new {rb.BookId, rb.BorrowerId});
            modelBuilder.Entity<ReturnBook>()
                .HasOne(rb => rb.Borrower)
                .WithMany(br => br.ReturnBooks)
                .HasForeignKey(rb => rb.BorrowerId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Entities.Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<BookIssue> BookIssues { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }
    }
}