using System.Linq.Expressions;
namespace Api.DAL
{
    public interface IGRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveAllAsync(IEnumerable<T> values);
    }
}
