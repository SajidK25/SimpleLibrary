using Autofac;
using SimpleLibrary.Book.Contexts;
using SimpleLibrary.Book.Repositories;
using SimpleLibrary.Book.Services;
using SimpleLibrary.Book.UnitOfWorks;

namespace SimpleLibrary.Book
{
    public class BookModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public BookModule(string connectionStringName, string migrationAssemblyName)
        {

            _connectionString = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            //builder.RegisterType<BillingContext>().As<IBillingContext>()
            //       .WithParameter("connectionString", _connectionString)
            //       .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            //       .InstancePerLifetimeScope();

            builder.RegisterType<BookunitOfWork>().As<IBookUnitOfWork>()
                //.WithParameter("connectionString", _connectionString)
                //.WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookService>().As<IBookService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}