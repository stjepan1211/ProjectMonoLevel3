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
        void AddVehicleModel(IVehicleModel vehicleModel);

        Task<IVehicleModel> FindVehicleModel(Guid id);

        void EditVehicleModel(IVehicleModel vehicleModel);

        void DeleteVehicleModel(Guid id);

        Task<IEnumerable<IVehicleModel>> GetVehicleModels();
    }
}
