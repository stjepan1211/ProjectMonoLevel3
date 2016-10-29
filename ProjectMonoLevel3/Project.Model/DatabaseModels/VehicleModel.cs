using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Model.Common.Interfaces;

namespace Project.Model.DatabaseModels
{
    public class VehicleModel : IVehicleModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleModelId { get; set; }
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }
}
