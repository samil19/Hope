using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;
        protected readonly DbSet<TEntity> _entity;


        public Repository(DbContext context)
        {
            _Context = context;
            _entity = _Context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return  _entity.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  _entity.ToList();
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return  _entity.Where(predicate);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return  _entity.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
             _entity.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
             _entity.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
             _entity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
             _entity.RemoveRange(entities);
        }
    }
}
