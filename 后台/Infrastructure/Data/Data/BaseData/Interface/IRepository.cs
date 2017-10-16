using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BaseData.Interface
{
    public interface IRepository<TEntity> where TEntity:IBaseEntity
    {
        /// <summary>
        /// 根据条件获取实体集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IList<TEntity> GetEntities(Expression<Func<IQueryable<TEntity>, bool>> expression);

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetEntity(object id);
        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TEntity entity);
        /// <summary>
        /// 批量更新实体数据
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Update(IEnumerable<TEntity> entities);
        /// <summary>
        /// 添加一个新的实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(TEntity entity);
        /// <summary>
        /// 指添加新实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Insert(IEnumerable<TEntity> entities);
        /// <summary>
        /// 删除一个实体 软删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(TEntity entity);
        /// <summary>
        /// 指删除实体集 软删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Delete(IEnumerable<TEntity> entities);
        /// <summary>
        /// 删除一个实体数据 物理删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TEntity entity);
        /// <summary>
        /// 删除实体集 物理删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Remove(IEnumerable<TEntity> entities);
    }
}
