using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.DatabaseModels;

namespace Project.Repository.Common
{
    public interface IVehickeMakeRepository : IGenericRepository<VehicleMake>
    {
        IEnumerable<VehicleMake> GetPagedVehicleMake(int pageIndex, int pageSize);
    }
}
