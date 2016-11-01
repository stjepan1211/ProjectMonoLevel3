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
        protected readonly DbContext _context;

        public GenerycRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Insert(TEntity tEntity)
        {
            _context.Set<TEntity>().Add(tEntity);
        }

        public void InsertRange(IEnumerable<TEntity> tEntities)
        {
            _context.Set<TEntity>().AddRange(tEntities);
        }

        public void Delete(TEntity tEntity)
        {
            //potrebno je prvo nac entity preko id-a i poslati ga
            _context.Set<TEntity>().Remove(tEntity);
        }

        public void DeleteRange(IEnumerable<TEntity> tEntities)
        {
            _context.Set<TEntity>().RemoveRange(tEntities);
        }

        public void Update(TEntity tEntity)
        {
            _context.Entry<TEntity>(tEntity).State = EntityState.Modified;
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }
    }
}
