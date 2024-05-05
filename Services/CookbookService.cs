using System.Linq.Expressions;
using Vlvt.Data.Repositories;
using Vlvt.Domain;

namespace Vlvt.Services;

public class CookbookService : ICookbookService
{
    private readonly IRepository<Cookbook> _repo;

    public CookbookService(IRepository<Cookbook> repo)
    {
        _repo = repo;
    }

    public async Task<bool> CookbookExistsAsync(long id)
    {
        return await _repo.ExistsAsync(id);
    }

    public async Task CreateCookbookAsync(Cookbook cookbook)
    {
        await _repo.AddAsync(cookbook);
    }

    public async Task DeleteCookbookAsync(long id)
    {
        await _repo.DeleteAsync(id);
    }

    public async Task<IEnumerable<Cookbook>> FilterCookbooksAsync(Expression<Func<Cookbook, bool>> predicate)
    {
        return await _repo.FilterAsync(predicate);
    }

    public async Task<Cookbook> FindCookbookAsync(Expression<Func<Cookbook, bool>> predicate)
    {
        return await _repo.FindAsync(predicate);
    }

    public async Task<Cookbook> GetCookbookByIdAsync(long id)
    {
        return await _repo.GetByIdAsync(id);
    }

    public async Task<List<Cookbook>> GetAllCookbooksAsync()
    {
        var cookbooks = await _repo.GetAllAsync();
        return cookbooks.ToList();
    }

    public async Task UpdateCookbookAsync(long id, Cookbook cookbook)
    {
        var exists = await _repo.ExistsAsync(id);
        
        if (exists)
        {
            await _repo.UpdateAsync(cookbook);
        }
    }
}