using System;
using System.Collections.Generic;
using AltenCarStore.Infrastructure.Repositories;
using AltenCarStore.VehicleService.Domain;

namespace AltenCarStore.VehicleService.Repositories
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        public Vehicle GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehicle @object)
        {
            throw new NotImplementedException();
        }

        public void Add(Vehicle @object)
        {
            throw new NotImplementedException();
        }

        public ICollection<Vehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Vehicle @object)
        {
            throw new NotImplementedException();
        }
    }
}
