using System.Linq.Expressions;

namespace Core.Interfaces.Services;

public interface IBaseService<TEntity> where TEntity : class
{
    TEntity Add(TEntity entity);
    void Update(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    void Remove(TEntity entity);
    //void Dispose();
}
