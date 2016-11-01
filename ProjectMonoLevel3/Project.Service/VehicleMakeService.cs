using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.DatabaseModels;
using Project.Service.Common;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private IVehicleMakeRepository vehicleMakeRepository;

        public VehicleMakeService(IVehicleMakeRepository vmkrep)
        {
            this.vehicleMakeRepository = vmkrep;
        }

        public async Task<IEnumerable<VehicleMake>> GetVehicleMakes()
        {
            return await vehicleMakeRepository.GetAll();
        }

        public void AddVehicleMake(VehicleMake vehicleMake)
        {
            vehicleMakeRepository.Insert(vehicleMake);
        }

        public async Task<VehicleMake> FindVehicleMake(Guid id)
        {
            return await vehicleMakeRepository.FindById(id);
        }

        public void EditVehicleMake(VehicleMake vehicleMake)
        {
            vehicleMakeRepository.Update(vehicleMake);
        }

        public void DeleteVehicleMake(VehicleMake vehicleMake)
        {
            vehicleMakeRepository.Delete(vehicleMake);
        }

    }
}
