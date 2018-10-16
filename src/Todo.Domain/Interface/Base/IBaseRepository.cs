using System.Linq;
using System.Threading.Tasks;

namespace Todo.Domain.Interface.Base
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}