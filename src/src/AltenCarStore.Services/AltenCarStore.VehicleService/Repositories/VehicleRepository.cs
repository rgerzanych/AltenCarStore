using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AltenCarStore.Infrastructure.Repositories;
using AltenCarStore.VehicleService.Data.Abstractions;
using AltenCarStore.VehicleService.Domain;

namespace AltenCarStore.VehicleService.Repositories
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        private readonly IVehiclesContext _context;

        public VehicleRepository(IVehiclesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Vehicle> GetByIdAsync(Guid id)
        {
            return await _context.Vehicles.FirstOrDefaultAsync(v => v.Id == id);
        }

        public void Update(Vehicle @object)
        {
            throw new NotImplementedException();
        }

        public void Add(Vehicle @object)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Vehicle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Vehicle>> FindAsync(Expression<Func<Vehicle, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Vehicle @object)
        {
            throw new NotImplementedException();
        }
    }
}
