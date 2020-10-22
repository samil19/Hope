using DataAccess.Interfaces;
using DataAccess.Models.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Base
    {
        protected readonly DbContext _Context;
        protected readonly DbSet<TEntity> _entity;
        protected readonly DbSet<Log> _logging;


        public Repository(DbContext context)
        {
            _Context = context;
            _entity = _Context.Set<TEntity>();
            _logging = _Context.Set<Log>();
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

        public void Add(TEntity entity, int LogInId)
        {
            _entity.Add(entity);
            SendLog(entity, "INSERT");
        
        }
        
        public TEntity Insert(TEntity entity, int LogInId)
        {
            TEntity ToReturn = _entity.Add(entity).Entity;
            SendLog(ToReturn, "INSERT");
            return ToReturn;
        }
        
        public void AddRange(IEnumerable<TEntity> entities, int LogInId)
        {
            _entity.AddRange(entities);
            SendLogList(entities, "INSERT");
        }

        public void Remove(TEntity entity, int LogInId)
        {
             _entity.Remove(entity);
            SendLog(entity, "DELETE");

        }

        public void RemoveRange(IEnumerable<TEntity> entities, int LogInId)
        {
             _entity.RemoveRange(entities);
                SendLogList(entities,"DELETE");
        }

        public TEntity InsertWithoutLog(TEntity entity)
        {
            TEntity ToReturn = _entity.Add(entity).Entity;
            return ToReturn;
        }

        private void SendLog(TEntity entity, string accion)
        {
            LogIntoDb(entity.GetType().ToString(), entity.Id, 0, accion);
        }
        private void SendLogList(IEnumerable<TEntity> entities, string accion)
        {
            entities.ToList().ForEach(entity =>
            {
                LogIntoDb(entity.GetType().ToString(), entity.Id, 0, accion);
            });
        }
        private void LogIntoDb(string ElementTable, int ElementId, int LogInId, string Accion)
        {
            _logging.Add(new Log { Accion = Accion, LogInId = LogInId, ElementId = ElementId, ElementTable = ElementTable });
        }
    }
}
