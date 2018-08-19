using AltenCarStore.Infrastructure.Domain;
using System.Collections.Generic;

namespace AltenCarStore.VehicleService.Domain
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
