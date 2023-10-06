using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<BlogApplicationDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("BlogApplicationConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IPostRepository, PostRepository>();
            return services;

        }
    }
}
