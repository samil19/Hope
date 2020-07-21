using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DataAccess.EntityFramework;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.Extensions.Configuration;

namespace Root
{
    public class CompositionRoot
    {
        public CompositionRoot() { }

        public static void InjectDependencies(IServiceCollection services)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            services.AddDbContext<HopeContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("Development")));
            services.AddScoped<HopeContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IAuthorRepository, AuthorRepository>();
            //services.AddScoped<IAuthorService, AuthorService>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
