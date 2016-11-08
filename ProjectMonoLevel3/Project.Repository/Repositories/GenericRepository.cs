using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;
using System.Data.Entity;
using Project.Repository.Common;
using System.Linq.Expressions;
using Project.DAL.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using Project.Model.DatabaseModels;

namespace Project.Repository.Repositories
{
    public class GenerycRepository : IGenericRepository
    {
        protected readonly IVehicleContext _context;

        public GenerycRepository(IVehicleContext context)
        {
            _context = context;
        }

        //Add
        public async Task<int> Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }
        //Get
        public async Task<T> Get<T>(Guid id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }
        //Delete
        public async Task<int> Delete<T>(Guid id) where T : class
        {
            T entity = await Get<T>(id);
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }
        //Update
        public async Task<int> Update<T>(T entity) where T : class
        {
            _context.Set<T>().AddOrUpdate(entity);
            return await _context.SaveChangesAsync();
        }
        //GetAll
        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public IQueryable<T> GetWhere<T>() where T : class
        {
            return _context.Set<T>();
        }
    }
}
