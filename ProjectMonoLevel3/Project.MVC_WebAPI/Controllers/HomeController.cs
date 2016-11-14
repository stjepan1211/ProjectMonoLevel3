using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Project.Service.Common;
using Project.Model.ViewModels;
using Project.Model.DatabaseModels;

namespace Project.MVC_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleMakeService vmkservice;
        public HomeController(IVehicleMakeService vmkservice)
        {
            this.vmkservice = vmkservice;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public async Task<ActionResult> MyIndex()
        {
            return View(AutoMapper.Mapper.Map<IEnumerable<VehicleMakeViewModel>>((await vmkservice.GetVehicleMakes())));
        }
        public ActionResult DetailsTemp()
        {
            return View(new VehicleModel() { Name = "F50", Abrv = "vslls", VehicleMakeId = Guid.NewGuid(), VehicleModelId= Guid.NewGuid()});
        }
    }
}
