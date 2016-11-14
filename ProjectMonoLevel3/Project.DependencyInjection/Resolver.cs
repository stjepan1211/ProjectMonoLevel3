using System;
using Ninject.Modules;
using Project.Service.Common;
using Project.Service;
using Project.Repository.Common;
using Project.Repository;
using Project.Repository.Repositories;
using Project.Model.Common;
using Project.Model.DatabaseModels;
using Project.DAL;
using Project.DAL.Common;
using Project.Model.DomainModels;


namespace Project.DependencyInjection
{
    public class Resolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicleMakeService>().To<VehicleMakeService>();
            Bind<IVehicleModelService>().To<VehicleModelService>();

            Bind<IGenericRepository>().To<GenerycRepository>();
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IVehicleMake>().To<VehicleMake>();
            Bind<IVehicleModel>().To<VehicleModel>();
            Bind<IVehicleMakeDomainModel>().To<VehicleMakeDomainModel>();
            Bind<IVehicleModelDomainModel>().To<VehicleModelDomainModel>();
            Bind<IVehicleContext>().To<VehicleContext>();

            //throw new NotImplementedException();
        }
    }
}
