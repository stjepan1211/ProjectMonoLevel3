using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.DatabaseModels;
using Project.DAL;
using Project.DAL.Common;
using Project.Model.Common;

namespace Project.Repository.Repositories
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private IGenericRepository _genericRepository;

        public VehicleMakeRepository(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }
        //Add
        public async Task<int> Add(IVehicleMake entity)
        {
            return await _genericRepository.Add<VehicleMake>((VehicleMake)entity);
        }
        //Get
        public async Task<IVehicleMake> Get(Guid id)
        {
            return await _genericRepository.Get<VehicleMake>(id);
        }
        //Update
        public async Task<int> Update(IVehicleMake entity)
        {
            return await _genericRepository.Update<VehicleMake>((VehicleMake)entity);
        }
        //Delete
        public async Task<int> Delete(Guid id)
        {
            return await _genericRepository.Delete<VehicleMake>(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleMake>> GetAll()
        {
            return await _genericRepository.GetAll<VehicleMake>();
        }
    }
}
