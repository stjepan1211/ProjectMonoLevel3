using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;

namespace Project.Repository.Common
{
    public interface IVehicleModelRepository : IGenericRepository<VehicleModel>
    {
        IEnumerable<VehicleModel> GetPagedVehicleModel(int pageIndex, int pageSize);
    }
}
