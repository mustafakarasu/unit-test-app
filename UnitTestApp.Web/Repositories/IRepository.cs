using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestApp.Web.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        
        Task<T> GetByIdAsync(int id);
        
        Task CreateAsync(T entity);
        
        void Update(T entity);
        
        void Delete(T entity);
    }
}