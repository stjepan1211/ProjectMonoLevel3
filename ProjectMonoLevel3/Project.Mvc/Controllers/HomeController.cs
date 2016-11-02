using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Service.Common;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IVehicleMakeService makeService;

        public HomeController(IVehicleMakeService makeService)
        {
            this.makeService = makeService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> MyIndex()
        {
            return View(await makeService.GetVehicleMakes());
        }
    }
}
