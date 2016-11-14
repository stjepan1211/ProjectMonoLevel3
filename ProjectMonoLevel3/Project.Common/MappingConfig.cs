using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model.DatabaseModels;
using Project.Model.DomainModels;
using Project.Model.Common;
using Project.DAL.Common;

namespace Project.Model
{
    public class MappingConfig : Profile
    {
        protected override void Configure()
        {

            CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
            //CreateMap<IVehicleMake, IVehicleMakeDomain>().ReverseMap();

            CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>().ReverseMap();

            CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
            CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();

            //Mapper.Initialize(config =>
            //{

            //    config.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
            //    config.CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();

            //    config.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
            //    config.CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();

            //    //config.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            //    config.CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
            //    //config.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();

            //    //config.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            //    config.CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            //    //config.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();

            //    config.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
            //    config.CreateMap<IVehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();
            //    //config.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            //    config.CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            //   // config.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            //    config.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
            //    config.CreateMap<IVehicleModel, IVehicleModelDomainModel>().ReverseMap();
            //    config.CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
            //    config.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();

            //    //config.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            //    config.CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();

            //    //config.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();

            //});
        }
    }
}
