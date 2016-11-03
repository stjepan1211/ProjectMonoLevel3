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
        Task<int> Add(IVehicleMakeDomainModel entity);
        Task<IVehicleMakeDomainModel> Get(Guid id);
        Task<int> Update(IVehicleMakeDomainModel entity);
        Task<int> Delete(Guid id);
        Task<IEnumerable<IVehicleMakeDomainModel>> GetAll();
    }
}
