using System.Linq.Expressions;

namespace Server.Data.Repositories;

public interface IRepository<T> where T : class
{
    Task<bool> ExistsAsync(long id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate);
    Task<T> FindAsync(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(long id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(long id);
}