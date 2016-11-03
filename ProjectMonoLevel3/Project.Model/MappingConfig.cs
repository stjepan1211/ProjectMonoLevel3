using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model.DatabaseModels;
using Project.Model.DomainModels;
using Project.Model.ViewModels;
using Project.Model.Common;

namespace Project.Model
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {

                config.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();   
                config.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
                config.CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
                config.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
                config.CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
                config.CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
                config.CreateMap<VehicleModel, IVehicleModelViewModel>().ReverseMap();

                config.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
                config.CreateMap<VehicleModelDomainModel, IVehicleModelViewModel>().ReverseMap();
                config.CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
                config.CreateMap<IVehicleModelDomainModel, IVehicleModelViewModel>().ReverseMap();
                config.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
                config.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
                config.CreateMap<VehicleMakeDomainModel, IVehicleMakeViewModel>().ReverseMap();
                config.CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<IVehicleMakeDomainModel, IVehicleMakeViewModel>().ReverseMap();
                config.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();


            });
        }
    }
}
