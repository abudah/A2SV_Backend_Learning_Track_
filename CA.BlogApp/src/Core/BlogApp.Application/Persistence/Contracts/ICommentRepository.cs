using BlogApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Persistence.Contracts
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<T> GetComments<T>(int id);
    }
}
