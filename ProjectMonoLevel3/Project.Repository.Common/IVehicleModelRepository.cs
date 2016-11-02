using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;
using Project.Model.Common;

namespace Project.Repository.Common
{
    public interface IVehicleModelRepository
    {
        Task<int> Add(IVehicleModel entity);
        Task<IVehicleModel> Get(Guid id);
        Task<int> Update(IVehicleModel entity);
        Task<int> Delete(Guid id);
        Task<IEnumerable<IVehicleModel>> GetAll();
    }
}
