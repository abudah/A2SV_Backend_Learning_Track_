using BlogApplication.Application.Persistence.Contracts;
using BlogApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Persistence.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        private readonly BlogApplicationDbContext _dbContext;
        public PostRepository(BlogApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }
    }
}
