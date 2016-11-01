using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;
using Project.Repository.Common;
using Project.DAL;

namespace Project.Repository.Repositories
{
    public class VehicleModelRepository : GenerycRepository<VehicleModel>, IVehicleModelRepository
    {
        public VehicleModelRepository(VehicleContext vehicleContext) : base(vehicleContext)
        {
        }

        //public VehicleContext VehicleContext { get { return _context as VehicleContext; } }

        //public async IEnumerable<VehicleModel> GetPagedVehicleModel(int pageIndex, int pageSize)
        //{
        //    return VehicleContext.VehicleModel.ToList();
        //}

    }
}
