using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Model.Common.Interfaces;

namespace Project.Model.DatabaseModels
{
    public class VehicleMake : IVehicleMake
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
