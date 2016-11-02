using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Service.Common;
using Project.Model;
using Project.Model.DatabaseModels;

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
        public void AddVehicleMake(IVehicleMake vehicleMake)
        {
            vehicleMakeRepository.Add(vehicleMake);
        }
        //Get
        public async Task<IVehicleMake> FindVehicleMake(Guid id)
        {
            return await vehicleMakeRepository.Get(id);
        }
        //Update
        public void EditVehicleMake(IVehicleMake vehicleMake)
        {
            vehicleMakeRepository.Update(vehicleMake);
        }
        //Delete
        public void DeleteVehicleMake(Guid id)
        {
            vehicleMakeRepository.Delete(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleMake>> GetVehicleMakes()
        {
            return await vehicleMakeRepository.GetAll();
        }
    }
}
