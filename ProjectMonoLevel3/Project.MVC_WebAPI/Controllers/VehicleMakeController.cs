using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Service.Common;
using Project.Model.ViewModels;
using AutoMapper;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.MVC_WebAPI.Controllers
{
    [RoutePrefix("api/VehicleMake")]
    public class VehicleMakeController : ApiController
    {
        private IVehicleMakeService vmkService;

        public VehicleMakeController(IVehicleMakeService vmkService)
        {
            this.vmkService = vmkService;
        }

        //GetAll
        [HttpGet]
        [Route("GetAllVmk")]
        public async Task<HttpResponseMessage> GetAllVehicleMakes()
        {
            var vehicleMakes = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await vmkService.GetVehicleMakes());
            return Request.CreateResponse(HttpStatusCode.OK, vehicleMakes);
        }

        [HttpPost]
        [Route("AddVmk")]
        public async Task<HttpResponseMessage> AddVehicleMake(VehicleMakeViewModel vmkViewModel)
        {
            //nemoj koristiti ModelState.IsValid, potrebna je provjera za svaki property modela je li null
            if (vmkViewModel.Name == null || vmkViewModel.Abrv == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Krivi podaci");

            vmkViewModel.VehicleMakeId = Guid.NewGuid();

            var response = await vmkService.AddVehicleMake(Mapper.Map<IVehicleMakeDomainModel>(vmkViewModel));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpPut]
        [Route("UpdateVmk")]
        public async Task<HttpResponseMessage> UpdateVehicleMake(Guid id, VehicleMakeViewModel vmkViewModel)
        {
            VehicleMakeViewModel vmkUpdate = Mapper.Map<VehicleMakeViewModel>(await vmkService.FindVehicleMake(id));
            if (vmkViewModel.Name == null || vmkViewModel.Abrv == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Neispravan unos.");
            }
            else
            {
                vmkUpdate.Name = vmkViewModel.Name;
                vmkUpdate.Abrv = vmkViewModel.Abrv;
            }

            var response = await vmkService.EditVehicleMake(Mapper.Map<IVehicleMakeDomainModel>(vmkUpdate));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpDelete]
        [Route("DeleteVmk")]
        public async Task<HttpResponseMessage> DeleteVehicleMake(Guid id)
        {
            VehicleMakeViewModel vmkDelete = Mapper.Map<VehicleMakeViewModel>(await vmkService.FindVehicleMake(id));
            if (vmkDelete == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Model nije pronađen.");

            var response = Mapper.Map<IVehicleMakeDomainModel>(await vmkService.DeleteVehicleMake(id));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpGet]
        [Route("GetVmk")]
        public async Task<HttpResponseMessage> GetVehicleMake(Guid id)
        {
            var response = Mapper.Map<IVehicleMakeDomainModel>(await vmkService.FindVehicleMake(id));

            if (response == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Model nije pronađen");

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
