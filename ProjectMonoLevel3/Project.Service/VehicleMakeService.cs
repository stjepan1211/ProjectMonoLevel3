using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
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

        //Add
        public async Task<int> AddVehicleMake(IVehicleMakeDomainModel vehicleMake)
        {
           return await vehicleMakeRepository.Add(vehicleMake);
        }
        //Get
        public async Task<IVehicleMakeDomainModel> FindVehicleMake(Guid id)
        {
            return await vehicleMakeRepository.Get(id);
        }
        //Update
        public async Task<int> EditVehicleMake(IVehicleMakeDomainModel vehicleMake)
        {
            return await vehicleMakeRepository.Update(vehicleMake);
        }
        //Delete
        public async Task<int> DeleteVehicleMake(Guid id)
        {
            return await vehicleMakeRepository.Delete(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetVehicleMakes()
        {
            return await vehicleMakeRepository.GetAll();
        }
    }
}
