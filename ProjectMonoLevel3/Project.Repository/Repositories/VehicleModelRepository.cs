using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;
using Project.Repository.Common;
using Project.DAL;
using Project.DAL.Common;
using Project.Model.Common;

namespace Project.Repository.Repositories
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private IGenericRepository _genericRepository;

        public VehicleModelRepository(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }
        //Add
        public async Task<int> Add(IVehicleModel entity)
        {
            return await _genericRepository.Add<VehicleModel>((VehicleModel)entity);
        }
        //Get
        public async Task<IVehicleModel> Get(Guid id)
        {
            return await _genericRepository.Get<VehicleModel>(id);
        }
        //Update
        public async Task<int> Update(IVehicleModel entity)
        {
            return await _genericRepository.Update<VehicleModel>((VehicleModel)entity);
        }
        //Delete
        public async Task<int> Delete(Guid id)
        {
            return await _genericRepository.Delete<VehicleModel>(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleModel>> GetAll()
        {
            return await _genericRepository.GetAll<VehicleModel>();
        }

    }
}
