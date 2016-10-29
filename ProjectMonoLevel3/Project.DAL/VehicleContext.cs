using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Project.Model.DatabaseModels;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Project.DAL
{
    class VehicleContext : DbContext
    {
        private static VehicleContext Instance;
        public VehicleContext() : base("VehicleContext")
        {
        }

        public static VehicleContext GetInstance()
        {
            if (Instance == null)
                Instance = new VehicleContext();
            return Instance;
        }

        public DbSet<VehicleMake> VehicleMake { get; set; }
        public DbSet<VehicleModel> VehicleModel { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
