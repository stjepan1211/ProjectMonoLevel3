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
        Task<TEntity> FindById(Guid id);

        Task<IEnumerable<TEntity>> GetAll();

        void Insert(TEntity tEntity);

        void InsertRange(IEnumerable<TEntity> tEntities);

        void Delete(TEntity tEntity);

        void DeleteRange(IEnumerable<TEntity> tEntities);

        void Update(TEntity tEntity);

        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
