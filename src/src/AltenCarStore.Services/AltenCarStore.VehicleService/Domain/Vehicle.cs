using AltenCarStore.Infrastructure.Domain;
using System;

namespace AltenCarStore.VehicleService.Domain
{
    public class Vehicle : EntityBase
    {
        public string Vin { get; set; }

        public string RegNumber { get; set; }

        public Guid OwnerId { get; set; }

        public Customer Owner { get; set; }
    }
}
