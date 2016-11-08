using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Model.ViewModels;

namespace Project.MVC_WebAPI.Controllers
{
    [RoutePrefix("api/VehicleModel")]
    public class VehicleModelController : ApiController
    {
        private IVehicleModelService vmlService;
        private IVehicleMakeService vmkService;
        public VehicleModelController(IVehicleModelService vmlService, IVehicleMakeService vmkService)
        {
            this.vmlService = vmlService;
            this.vmkService = vmkService;
        }

        [HttpGet]
        [Route("GetAllVml")]
        public async Task<HttpResponseMessage> GetAllVehicleModels()
        {
            var vehicleModels = Mapper.Map<IEnumerable<VehicleModelViewModel>>(await vmlService.GetVehicleModels());
            //foreach (var item in vehicleModels)
            //{
            //    item.VehicleMake =
            //        Mapper.Map<VehicleMakeViewModel>(await vmkService.FindVehicleMake(item.VehicleMakeId));
            //}
            return Request.CreateResponse(HttpStatusCode.OK, vehicleModels);
        }

        [HttpPost]
        [Route("AddVml")]
        public async Task<HttpResponseMessage> AddVehicleModel(VehicleModelViewModel vmlViewModel)
        {
            if (vmlViewModel.Name == null || vmlViewModel.Abrv == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Krivi podaci");

            vmlViewModel.VehicleModelId = Guid.NewGuid();

            var response = await vmlService.AddVehicleModel(Mapper.Map<IVehicleModelDomainModel>(vmlViewModel));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpPut]
        [Route("UpdateVml")]
        public async Task<HttpResponseMessage> UpdateVehicleModel(Guid id, VehicleModelViewModel vmlViewModel)
        {
            VehicleModelViewModel vmlUpdate = Mapper.Map<VehicleModelViewModel>(await vmlService.FindVehicleModel(id));
            if (vmlViewModel.Name == null || vmlViewModel.Abrv == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Neispravan unos.");
            }
            else
            {
                vmlUpdate.Name = vmlViewModel.Name;
                vmlUpdate.Abrv = vmlViewModel.Abrv;
            }

            var response = await vmlService.EditVehicleModel(Mapper.Map<IVehicleModelDomainModel>(vmlUpdate));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpDelete]
        [Route("DeleteVml")]
        public async Task<HttpResponseMessage> DeleteVehicleModel(Guid id)
        {
            IVehicleModelDomainModel vmlDelete = Mapper.Map<IVehicleModelDomainModel>(await vmlService.FindVehicleModel(id));
            if (vmlDelete == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Model nije pronađen.");

            var response = Mapper.Map<IVehicleModelDomainModel>(await vmlService.DeleteVehicleModel(id));

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpGet]
        [Route("GetVml")]
        public async Task<HttpResponseMessage> GetVehicleModel(Guid id)
        {
            var response = Mapper.Map<IVehicleModelDomainModel>(await vmlService.FindVehicleModel(id));

            if (response == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Model nije pronađen");

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
