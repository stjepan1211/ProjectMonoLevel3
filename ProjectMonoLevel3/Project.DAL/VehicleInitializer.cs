using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Project.Model.DatabaseModels;

namespace Project.DAL
{
    class VehicleInitializer : DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var vehicleMakes = new List<VehicleMake>()
            {
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Volkswagen", Abrv="VW"},
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Bayerische Motoren Werke", Abrv="BMW"},
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Chevrolet",Abrv="Unknown"},
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Rimac",Abrv="Unknown"},
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Audi", Abrv="Unknown"},
                new VehicleMake{VehicleMakeId = Guid.NewGuid(), Name="Nissan", Abrv="Unknown"}
            };
            vehicleMakes.ForEach(vmk => context.VehicleMake.Add(vmk));
            context.SaveChanges();

            //var vehicleModels = new List<VehicleModel>
            //{
            //};
            //vehicleModels.ForEach(vmd => context.VehicleModels.Add(vmd));
            //context.SaveChanges();
            base.Seed(context);
        }
    }
}