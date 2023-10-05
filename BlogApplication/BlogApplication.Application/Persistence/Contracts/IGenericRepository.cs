using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Application.Persistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetDetail(int id);
        Task<IReadOnlyList<T>> GetList();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);

    }
}
