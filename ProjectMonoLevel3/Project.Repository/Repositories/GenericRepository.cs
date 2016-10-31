using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;
using System.Data.Entity;
using Project.Repository.Common;
using System.Linq.Expressions;

namespace Project.Repository.Repositories
{
    public class GenerycRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public GenerycRepository(DbContext context)
        {
            this.Context = context;
        }

        public TEntity Get(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Add(TEntity tEntity)
        {
            Context.Set<TEntity>().Add(tEntity);
        }

        public void AddRange(IEnumerable<TEntity> tEntities)
        {
            Context.Set<TEntity>().AddRange(tEntities);
        }

        public void Remove(TEntity tEntity)
        {
            Context.Set<TEntity>().Remove(tEntity);
        }

        public void RemoveRange(IEnumerable<TEntity> tEntities)
        {
            Context.Set<TEntity>().RemoveRange(tEntities);
        }

        public void Edit(TEntity tEntity)
        {
            Context.Entry<TEntity>(tEntity).State = EntityState.Modified;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }
    }
}
