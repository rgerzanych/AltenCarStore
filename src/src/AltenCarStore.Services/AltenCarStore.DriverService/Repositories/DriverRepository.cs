using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenCarStore.DriverService.Domain;
using AltenCarStore.Infrastructure.Repositories;

namespace AltenCarStore.DriverService.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        public Driver GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Driver @object)
        {
            throw new NotImplementedException();
        }

        public void Add(Driver @object)
        {
            throw new NotImplementedException();
        }

        public ICollection<Driver> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Driver @object)
        {
            throw new NotImplementedException();
        }
    }
}
