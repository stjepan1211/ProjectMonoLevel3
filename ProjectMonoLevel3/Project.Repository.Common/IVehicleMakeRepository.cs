using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;
using Project.Model.Common;

namespace Project.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        Task<int> Add(IVehicleMake entity);
        Task<IVehicleMake> Get(Guid id);
        Task<int> Update(IVehicleMake entity);
        Task<int> Delete(Guid id);
        Task<IEnumerable<IVehicleMake>> GetAll();
    }
}
