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
        Task<int> AddVehicleMake(IVehicleMakeDomainModel vehicleMake);

        Task<IVehicleMakeDomainModel> FindVehicleMake(Guid id);

        Task<int> EditVehicleMake(IVehicleMakeDomainModel vehicleMake);

        Task<int> DeleteVehicleMake(Guid id);

        Task<IEnumerable<IVehicleMakeDomainModel>> GetVehicleMakes();
    }
}
