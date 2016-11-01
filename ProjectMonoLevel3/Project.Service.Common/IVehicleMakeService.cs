using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        void AddVehicleMake(VehicleMake vehicleMake);

        Task<VehicleMake> FindVehicleMake(Guid id);

        void EditVehicleMake(VehicleMake vehicleMake);

        void DeleteVehicleMake(VehicleMake vehicleMake);

        Task<IEnumerable<VehicleMake>> GetVehicleMakes();
    }
}
