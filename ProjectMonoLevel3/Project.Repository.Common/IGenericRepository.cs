using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Repository.Common
{
    public interface IGenericRepository
    {
        Task<int> Add<T>(T entity) where T : class;
        Task<T> Get<T>(Guid id) where T : class;
        Task<int> Update<T>(T entity) where T : class;
        Task<int> Delete<T>(Guid id) where T : class;
        Task<IEnumerable<T>> GetAll<T>() where T : class;
    }
}
