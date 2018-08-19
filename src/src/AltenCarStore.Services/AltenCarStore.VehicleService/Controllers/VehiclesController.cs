using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AltenCarStore.VehicleService.Data.Abstractions;
using AltenCarStore.VehicleService.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AltenCarStore.VehicleService.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehiclesContext _vehiclesContext;

        public VehiclesController(IVehiclesContext vehiclesContext)
        {
            _vehiclesContext = vehiclesContext ?? throw new ArgumentNullException(nameof(vehiclesContext));
        }

        // GET api/vehicles
        [HttpGet]
        public IEnumerable<VehicleDto> Get([FromQuery] string ownerid = null, [FromQuery] bool? isConnected = null)
        {
            var vehiclesQuery = _vehiclesContext.Vehicles.Include(v => v.Owner).AsQueryable();
            if (!string.IsNullOrEmpty(ownerid))
            {
                Guid owner;
                Guid.TryParse(ownerid, out owner);
                vehiclesQuery = vehiclesQuery.Where(v => v.OwnerId == owner);
            }
            var vehicles = vehiclesQuery.ToList();
            
            // TODO: should be changed
            return new List<VehicleDto>();
        }

        // GET api/vehicles/5
        [HttpGet("{id}")]
        public VehicleDto GetById(string id)
        {
            Guid vehicleId;
            Guid.TryParse(id, out vehicleId);
            var vehicles = _vehiclesContext.Vehicles.SingleOrDefaultAsync(v => v.Id == vehicleId);

            // TODO: should be changed
            return new VehicleDto();
        }
    }
}
