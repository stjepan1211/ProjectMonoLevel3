using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Service.Common
{
    public interface IVehicleModelService
    {
        Task<int> AddVehicleModel(IVehicleModelDomainModel vehicleModel);

        Task<IVehicleModelDomainModel> FindVehicleModel(Guid id);

        Task<int> EditVehicleModel(IVehicleModelDomainModel vehicleModel);

        Task<int> DeleteVehicleModel(Guid id);

        Task<IEnumerable<IVehicleModelDomainModel>> GetVehicleModels();
    }
}
