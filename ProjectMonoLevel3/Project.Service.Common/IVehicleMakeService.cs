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
        void AddVehicleMake(IVehicleMakeDomainModel vehicleMake);

        Task<IVehicleMakeDomainModel> FindVehicleMake(Guid id);

        void EditVehicleMake(IVehicleMakeDomainModel vehicleMake);

        void DeleteVehicleMake(Guid id);

        Task<IEnumerable<IVehicleMakeDomainModel>> GetVehicleMakes();
    }
}
