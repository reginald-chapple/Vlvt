using System.Linq.Expressions;
using Vlvt.Domain;

namespace Vlvt.Services;

public interface ICookbookService
{
    Task<bool> CookbookExistsAsync(long id);
    Task<List<Cookbook>> GetAllCookbooksAsync();
    Task<IEnumerable<Cookbook>> FilterCookbooksAsync(Expression<Func<Cookbook, bool>> predicate);
    Task<Cookbook> FindCookbookAsync(Expression<Func<Cookbook, bool>> predicate);
    Task<Cookbook> GetCookbookByIdAsync(long id);
    Task CreateCookbookAsync(Cookbook cookbook);
    Task UpdateCookbookAsync(long id, Cookbook cookbook);
    Task DeleteCookbookAsync(long id);
}