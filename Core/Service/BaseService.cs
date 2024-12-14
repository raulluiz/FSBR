using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
{
    private readonly IBaseRepository<TEntity> _repository;
    public BaseService(IBaseRepository<TEntity> repositoryBase)
    {
        _repository = repositoryBase;
    }
    public virtual TEntity Add(TEntity entity)
    {
        return _repository.Add(entity);
    }
    public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
    {
        return _repository.Get(predicate);
    }
    public virtual IEnumerable<TEntity> GetAll()
    {
        return _repository.GetAll();
    }
    public virtual TEntity GetById(int id)
    {
        return _repository.GetById(id);
    }
    public virtual void Remove(TEntity entity)
    {
        _repository.Remove(entity);
    }
    public virtual void Update(TEntity entity)
    {
        _repository.Update(entity);
    }
}
