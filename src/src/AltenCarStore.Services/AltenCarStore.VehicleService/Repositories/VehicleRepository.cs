using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AltenCarStore.Infrastructure.Repositories;
using AltenCarStore.VehicleService.Data.Abstractions;
using AltenCarStore.VehicleService.Domain;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ICollection<Vehicle>> GetAllAsync()
        {
            return await _context.Vehicles.ToListAsync();
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
