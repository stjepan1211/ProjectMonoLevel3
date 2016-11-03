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
        void AddVehicleModel(IVehicleModelDomainModel vehicleModel);

        Task<IVehicleModelDomainModel> FindVehicleModel(Guid id);

        void EditVehicleModel(IVehicleModelDomainModel vehicleModel);

        void DeleteVehicleModel(Guid id);

        Task<IEnumerable<IVehicleModelDomainModel>> GetVehicleModels();
    }
}
