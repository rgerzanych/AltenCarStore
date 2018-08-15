using AltenCarStore.VehicleService.Domain;

namespace AltenCarStore.VehicleService.Data.Abstractions
{
    public interface IVehiclesContext
    {
        System.Data.Entity.DbSet<Vehicle> Vehicles { get; set; }
    }
}
