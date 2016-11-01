using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.DAL;
using Project.Repository;
using Project.Repository.Repositories;
using Project.Model.DatabaseModels;
using Project.Repository.Common;
using System.Threading.Tasks;
using Project.Service.Common;
using Project.Service;

namespace Project.Mvc.Controllers
{
    public class MyController : Controller
    {
        private VehicleContext db = new VehicleContext();
        // GET: My
        public async Task<ActionResult> Index()
        {
            UnitOfWork unitOfWork = new UnitOfWork(db);
            VehicleMakeService vmkService = new VehicleMakeService(unitOfWork.VehicleMakes);
            return View(await vmkService.GetVehicleMakes());
        }
    }
}