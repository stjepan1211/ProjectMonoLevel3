using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Project.DAL;
using Project.Model.DatabaseModels;
using Project.Service.Common;
using AutoMapper;
using Project.Model.ViewModels;

namespace Project.MVC_WebAPI.Controllers
{
    public class TestApiController : ApiController
    {
        private VehicleContext db = new VehicleContext();
        private IVehicleMakeService vmkService;

        public TestApiController(IVehicleMakeService vmkService)
        {
            this.vmkService = vmkService;
        }

        // GET: api/TestApi
        [HttpGet]
        public async Task<HttpResponseMessage> GetAll()
        {
            var response = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await vmkService.GetVehicleMakes());
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        // GET: api/TestApi/5
        [ResponseType(typeof(VehicleMake))]
        public async Task<IHttpActionResult> GetVehicleMake(Guid id)
        {
            VehicleMake vehicleMake = await db.VehicleMake.FindAsync(id);
            if (vehicleMake == null)
            {
                return NotFound();
            }
            return Ok(vehicleMake);
        }

        // PUT: api/TestApi/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicleMake(Guid id, VehicleMake vehicleMake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicleMake.VehicleMakeId)
            {
                return BadRequest();
            }

            db.Entry(vehicleMake).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleMakeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TestApi
        [ResponseType(typeof(VehicleMake))]
        public async Task<IHttpActionResult> PostVehicleMake(VehicleMake vehicleMake)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VehicleMake.Add(vehicleMake);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vehicleMake.VehicleMakeId }, vehicleMake);
        }

        // DELETE: api/TestApi/5
        [ResponseType(typeof(VehicleMake))]
        public async Task<IHttpActionResult> DeleteVehicleMake(Guid id)
        {
            VehicleMake vehicleMake = await db.VehicleMake.FindAsync(id);
            if (vehicleMake == null)
            {
                return NotFound();
            }

            db.VehicleMake.Remove(vehicleMake);
            await db.SaveChangesAsync();

            return Ok(vehicleMake);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleMakeExists(Guid id)
        {
            return db.VehicleMake.Count(e => e.VehicleMakeId == id) > 0;
        }
    }
}