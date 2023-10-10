using BlogApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Persistence.Configurations.Entities
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post
                { 
                    Id = 1,
                    Title = "This is the first Post",
                    Content = "This is the content for the first post"
                },
                new Post
                {
                    Id = 2,
                    Title = "This is the Second Post",
                    Content = "This is the content for the Second post"
                });
        }
    }
}
