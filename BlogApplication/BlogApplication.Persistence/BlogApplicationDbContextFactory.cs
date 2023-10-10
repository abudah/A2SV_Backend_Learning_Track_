using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Persistence
{
    public class BlogApplicationDbContextFactory : IDesignTimeDbContextFactory<BlogApplicationDbContext>
    {
        public BlogApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BlogApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("BlogApplicationConnectionString");
            builder.UseNpgsql(connectionString);

            return new BlogApplicationDbContext(builder.Options);   
        }
    }
}
