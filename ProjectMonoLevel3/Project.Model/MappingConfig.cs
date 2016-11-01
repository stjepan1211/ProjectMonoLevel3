using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model.DatabaseModels;
using Project.Model.DomainModels;
using Project.Model.ViewModels;

namespace Project.Model
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
                config.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
                config.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            });
        }
    }
}
