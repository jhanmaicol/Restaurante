using RestauranteStore.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RestauranteStore.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;

        //public Repository(DbContext context)
        //{
        //    _Context = context;
        //}

        //void IRepository<TEntity>.Add(TEntity entity)
        public void Delete(TEntity entity)
        {
            //throw new NotImplementedException();
            _Context.Set<TEntity>().Remove(entity);
        }

        //void IRepository<TEntity>DeleteRange(IEnumerable<TEntity> entities)
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            //throw new NotImplementedException();
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        //void IRepository<TEntity>.Delete(TEntity entity)
         public TEntity Get(int ? id)
        {
            //throw new NotImplementedException();
            return _Context.Set<TEntity>().Find(id);
        }

        //void IRepository<TEntity>.DeleteRange(IEnumerable<TEntity> entities)
        public IEnumerable<TEntity> GetAll()
        {
            //throw new NotImplementedException();
            return _Context.Set<TEntity>().ToList();

        }

        //IEnumerator<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            //throw new NotImplementedException();
            return _Context.Set<TEntity>().Where(predicate);
        }

        //TEntity IRepository<TEntity>.Get(int ? Id)
        public void Add(TEntity entity)
        {
            //throw new NotImplementedException();
            _Context.Set<TEntity>().Add(entity);
        }

        //IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        public void AddRange(IEnumerable<TEntity> entities)
        {
            //throw new NotImplementedException();
            _Context.Set<TEntity>().AddRange(entities);
        }

        //void IRepository<TEntity>.Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRepository<TEntity>.UpdateRange(IEnumerable<TEntity> entities)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
