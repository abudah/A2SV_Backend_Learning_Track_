using BlogApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Application.Persistence.Contracts
{
    public interface IPostRepository : IGenericRepository<Post>    
    {

    }
}
