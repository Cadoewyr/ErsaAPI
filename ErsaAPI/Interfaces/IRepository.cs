using ErsaAPI.DAL.Entities;

namespace ErsaAPI.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        bool Add(T entity);
        bool Update(int id, T entity);
        bool Delete(int id);
    }
}
