using System.Linq.Expressions;

namespace ClientTransactionAPI.Repositories.Generic;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>?> GetAll();
    Task<T?> Get(Expression<Func<T, bool>> predicate);
    Task<T?> Create(T entity);
    Task<T?> Update(T entity);
    Task<T?> Delete(T entity);
}