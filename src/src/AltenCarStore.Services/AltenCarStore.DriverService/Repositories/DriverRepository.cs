using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AltenCarStore.DriverService.Domain;
using AltenCarStore.Infrastructure.Repositories;

namespace AltenCarStore.DriverService.Repositories
{
    public class DriverRepository : IRepository<Driver>
    {
        public Task<Driver> GetByIdAsync(Guid id)
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

        public Task<ICollection<Driver>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Driver>> FindAsync(Expression<Func<Driver, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Driver @object)
        {
            throw new NotImplementedException();
        }
    }
}
