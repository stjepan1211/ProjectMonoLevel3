using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();

        void Add(TEntity tEntity);

        void AddRange(IEnumerable<TEntity> tEntities);

        void Remove(TEntity tEntity);

        void RemoveRange(IEnumerable<TEntity> tEntities);

        void Edit(TEntity tEntity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

    }
}
