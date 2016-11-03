using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;
using Project.Service.Common;

namespace Project.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        private IVehicleModelRepository vehicleModelRepository;

        public VehicleModelService(IVehicleModelRepository vmlrep)
        {
            this.vehicleModelRepository = vmlrep;
        }
        //Add
        public async Task<int> AddVehicleModel(IVehicleModelDomainModel vehicleModel)
        {
            return await vehicleModelRepository.Add(vehicleModel);
        }
        //Get
        public async Task<IVehicleModelDomainModel> FindVehicleModel(Guid id)
        {
            return await vehicleModelRepository.Get(id);
        }
        //Update
        public async Task<int> EditVehicleModel(IVehicleModelDomainModel vehicleModel)
        {
            return await vehicleModelRepository.Update(vehicleModel);
        }
        //Delete
        public async Task<int> DeleteVehicleModel(Guid id)
        {
            return await vehicleModelRepository.Delete(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleModelDomainModel>> GetVehicleModels()
        {
            return await vehicleModelRepository.GetAll();
        }
    }
}
