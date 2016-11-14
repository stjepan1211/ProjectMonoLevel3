using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Model.ViewModels;
using Project.Model.DomainModels;
using Project.Model.Common;

namespace Project.MVC_WebAPI.Automapper
{
    public class MappingConfig : Profile
    {
        protected override void Configure()
        {
            //Domain to View
            CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
            //CreateMap<VehicleMakeDomain, IVehicleMakeView>().ReverseMap();
            CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
            //CreateMap<IVehicleMakeDomain, IVehicleMakeView>().ReverseMap();
            CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();


            CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            //CreateMap<VehicleModelDomain, IVehicleModelView>().ReverseMap();
            CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
            //CreateMap<IVehicleModelDomain, IVehicleModelView>().ReverseMap();
            CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
        }
    }
}