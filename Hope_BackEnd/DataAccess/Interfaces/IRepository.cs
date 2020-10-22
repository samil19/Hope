using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Base
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity, int LogInId);
        TEntity Insert(TEntity entity, int LogInId);
        void AddRange(IEnumerable<TEntity> entities, int LogInId);

        void Remove(TEntity entity, int LogInId);
        void RemoveRange(IEnumerable<TEntity> entities, int LogInId);
        TEntity InsertWithoutLog(TEntity entity);
    }
}
