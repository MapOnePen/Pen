using SourcePoint.Data.BaseData.Interface;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SourcePoint.Data.BaseData.Base
{
    public  class BaseService<TEntity> : IBaseService<TEntity> where TEntity:IBaseEntity
    {
        protected IRepository<TEntity> _repository;
        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual bool Delete(TEntity entity)
        {
            return _repository.Delete(entity);
        }

        public virtual bool Delete(IEnumerable<TEntity> entities)
        {
            return _repository.Delete(entities);
        }

        public IList<TEntity> GetEntities(Expression<Func<IQueryable<TEntity>, bool>> expression)
        {
            return _repository.GetEntities(expression);
        }

        public virtual TEntity GetEntity(object id)
        {
            return _repository.GetEntity(id);
        }

        public virtual bool Insert(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public virtual bool Insert(IEnumerable<TEntity> entities)
        {
            return _repository.Insert(entities);
        }

        public virtual bool Remove(TEntity entity)
        {
            return _repository.Remove(entity);
        }

        public virtual bool Remove(IEnumerable<TEntity> entities)
        {
            return _repository.Remove(entities);
        }

        public virtual bool Update(TEntity entity)
        {
            return _repository.Update(entity);
        }

        public virtual int Update(IEnumerable<TEntity> entities)
        {
            return _repository.Update(entities);
        }
    }
}
