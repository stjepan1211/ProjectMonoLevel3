using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;
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

        public async Task<IEnumerable<VehicleModel>> GetVehicleModels()
        {
            return await vehicleModelRepository.GetAll();
        }

        public void AddVehicleModel(VehicleModel vehicleModel)
        {
            vehicleModelRepository.Insert(vehicleModel);
        }

        public async Task<VehicleModel> FindVehicleModel(Guid id)
        {
            return await vehicleModelRepository.FindById(id);
        }

        public void EditVehicleModel(VehicleModel vehicleModel)
        {
            vehicleModelRepository.Update(vehicleModel);
        }

        public void DeleteVehicleModel(VehicleModel vehicleModel)
        {
            vehicleModelRepository.Delete(vehicleModel);
        }

    }
}
