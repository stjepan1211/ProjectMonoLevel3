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
using AutoMapper;
using Project.Model.DomainModels;
using System.Data.Entity;

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
        public async Task<int> Add(IVehicleModelDomainModel entity)
        {
            return await _genericRepository.Add<VehicleModel>(Mapper.Map<VehicleModel>(entity));
        }
        //Get
        public async Task<IVehicleModelDomainModel> Get(Guid id)
        {
            var obj = await _genericRepository.Get<VehicleModel>(id);
            return Mapper.Map<VehicleModelDomainModel>(obj);
        }
        //Update
        public async Task<int> Update(IVehicleModelDomainModel entity)
        {
            return await _genericRepository.Update<VehicleModel>(Mapper.Map<VehicleModel>(entity));
        }
        //Delete
        public async Task<int> Delete(Guid id)
        {
            return await _genericRepository.Delete<VehicleModel>(id);
        }
        //GetAll
        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAll()
        {
            //var response = Mapper.Map<IEnumerable<IVehicleModelDomainModel>>(await _genericRepository.GetAll<VehicleModel>());
            //return response;
            try
            {
                var response = Mapper.Map<IEnumerable<IVehicleModelDomainModel>>(await _genericRepository.GetWhere<VehicleModel>().Include(d => d.VehicleMake).ToListAsync());
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
