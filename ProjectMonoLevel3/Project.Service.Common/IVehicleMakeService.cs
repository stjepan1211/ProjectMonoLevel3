using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        void AddVehicleMake(IVehicleMake vehicleMake);

        Task<IVehicleMake> FindVehicleMake(Guid id);

        void EditVehicleMake(IVehicleMake vehicleMake);

        void DeleteVehicleMake(Guid id);

        Task<IEnumerable<IVehicleMake>> GetVehicleMakes();
    }
}
