using System.Linq.Expressions;

namespace api_basica.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);
        void DeleteAsync(T entity);
        Task<IEnumerable<T>> Get();
        Task<T?> GetOne(Expression<Func<T, bool>> funcion);
        Task<int> SaveChanges();
        void Update(T entity);
    }
}