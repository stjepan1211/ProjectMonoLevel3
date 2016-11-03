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
using AutoMapper;
using Project.Model.DomainModels;

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
        public async Task<int> Add(IVehicleMakeDomainModel entity)
        {
            return await _genericRepository.Add<VehicleMake>(Mapper.Map<VehicleMake>(entity));
        }
        //Get
        public async Task<IVehicleMakeDomainModel> Get(Guid id)
        {
            return Mapper.Map<VehicleMakeDomainModel>(await _genericRepository.Get<VehicleMake>(id));
        }
        //Update
        public async Task<int> Update(IVehicleMakeDomainModel entity)
        {
            return await _genericRepository.Update<VehicleMake>(Mapper.Map<VehicleMake>(entity));
        }
        //Delete
        public async Task<int> Delete(Guid id)
        {
            return await _genericRepository.Delete<VehicleMake>(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAll()
        {
            return Mapper.Map<IEnumerable<VehicleMakeDomainModel>>(await _genericRepository.GetAll<VehicleMake>());
        }
    }
}
