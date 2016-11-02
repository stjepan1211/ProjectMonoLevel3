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
        public void AddVehicleModel(IVehicleModel vehicleModel)
        {
            vehicleModelRepository.Add(vehicleModel);
        }
        //Get
        public async Task<IVehicleModel> FindVehicleModel(Guid id)
        {
            return await vehicleModelRepository.Get(id);
        }
        //Update
        public void EditVehicleModel(IVehicleModel vehicleModel)
        {
            vehicleModelRepository.Update(vehicleModel);
        }
        //Delete
        public void DeleteVehicleModel(Guid id)
        {
            vehicleModelRepository.Delete(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleModel>> GetVehicleModels()
        {
            return await vehicleModelRepository.GetAll();
        }
    }
}
