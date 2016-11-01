﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Model.DatabaseModels;

namespace Project.Model.DomainModels
{
    public class VehicleMakeDomainModel : IVehicleMakeDomainModel
    {
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public ICollection<VehicleModel> VehicleModel;
    }
}
