using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.DatabaseModels;
using Project.DAL;

namespace Project.Repository.Repositories
{
    public class VehicleMakeRepository : GenerycRepository<VehicleMake>, IVehickeMakeRepository
    {
        public VehicleMakeRepository(VehicleContext vehicleContext) : base(vehicleContext)
        {
        }
        public VehicleContext VehicleContext { get { return Context as VehicleContext; } }

        public IEnumerable<VehicleMake> GetPagedVehicleMake(int pageIndex, int pageSize)
        {
            //potrebno koristiti paged list
            return VehicleContext.VehicleMake.ToList();
        }
    }
}
