using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;
using Project.Repository.Common;
using Project.Repository.Repositories;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehicleContext context;

        public UnitOfWork(VehicleContext context)
        {
            this.context = context;
            VehicleMakes = new VehicleMakeRepository(context);
            VehicleModels = new VehicleModelRepository(context);
        }

        public IVehickeMakeRepository VehicleMakes { get; private set; }
        public IVehicleModelRepository VehicleModels { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
