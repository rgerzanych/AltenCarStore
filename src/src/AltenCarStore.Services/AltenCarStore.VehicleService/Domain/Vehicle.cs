using AltenCarStore.Infrastructure.Domain;

namespace AltenCarStore.VehicleService.Domain
{
    public class Vehicle : EntityBase
    {
        public string Vin { get; set; }

        public string RegNumber { get; set; }
    }
}
