using System;
using Autofac;
using SimpleLibrary.Core.Contexts;
using SimpleLibrary.Core.Repositories;
using SimpleLibrary.Core.Services;
using SimpleLibrary.Core.UnitOfWorks;

namespace SimpleLibrary.Core
{
    public class CoreModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public CoreModule(string connectionStringName, string migrationAssemblyName)
        {

            _connectionString = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
         
            builder.RegisterType<LibraryContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            
            builder.RegisterType<CoreUnitOfWork>().As<ICoreUnitOfWork>()
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