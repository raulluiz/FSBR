using System.Linq.Expressions;

namespace Core.Interfaces.Repository;

public interface IBaseRepository<TEntity> where TEntity : class
{
    TEntity Add(TEntity entity);
    void Update(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity GetById(int id);
    IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    void Remove(TEntity entity);
    void BeginTransaction();
    void Commit();
    void Rollback();
}
