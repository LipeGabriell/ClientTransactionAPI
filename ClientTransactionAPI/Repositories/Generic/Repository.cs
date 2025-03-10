using System.Linq.Expressions;
using ClientTransactionAPI.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ClientTransactionAPI.Repositories.Generic;

public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : class
{
    public async Task<IEnumerable<T>?> GetAll()
    {
        return await context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> Get(Expression<Func<T, bool>> predicate)
    {
        return await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
    }


    public async Task<T?> Create(T entity)
    {
        var added = await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
        return added.Entity;
    }

    public async Task<T?> Update(T entity)
    {
        context.Set<T>().Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<T?> Delete(T entity)
    {
        var deleted = context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();
        return deleted.Entity;
    }
}