#nullable disable
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Server.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private DbSet<T> entities;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        entities = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await entities.ToListAsync();
    }

    public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate)
    {
        return await entities.Where(predicate).ToListAsync();
    }

    public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await entities.FirstOrDefaultAsync(predicate);
    }

    public async Task<T> GetByIdAsync(long id)
    {
        return await entities.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await entities.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        entities.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(long id)
    {
        T entity = await GetByIdAsync(id);
        entities.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(long id)
    {
        return await entities.AnyAsync(e => EF.Property<long>(e, "Id") == id);
    }
}