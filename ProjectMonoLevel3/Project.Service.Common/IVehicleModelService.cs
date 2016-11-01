using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;

namespace Project.Service.Common
{
    public interface IVehicleModelService
    {
        void AddVehicleModel(VehicleModel vehicleModel);

        Task<VehicleModel> FindVehicleModel(Guid id);

        void EditVehicleModel(VehicleModel vehicleModel);

        void DeleteVehicleModel(VehicleModel vehicleModel);

        Task<IEnumerable<VehicleModel>> GetVehicleModels();

    }
}
