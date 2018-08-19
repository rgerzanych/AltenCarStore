using AltenCarStore.VehicleService.Domain;
using Microsoft.EntityFrameworkCore;

namespace AltenCarStore.VehicleService.Data.Abstractions
{
    public interface IVehiclesContext
    {
        DbSet<Vehicle> Vehicles { get; set; }

        DbSet<Customer> Customers { get; set; }
    }
}
