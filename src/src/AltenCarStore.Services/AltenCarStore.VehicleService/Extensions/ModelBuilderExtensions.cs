using AltenCarStore.VehicleService.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AltenCarStore.VehicleService.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle() { Id = Guid.NewGuid(), Vin = "YS2R4X20005399401", RegNumber = "ABC123" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "VLUR4X20009093588", RegNumber = "DEF456" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "VLUR4X20009048066", RegNumber = "GHI789" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "YS2R4X20005388011", RegNumber = "JKL012" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "YS2R4X20005387949", RegNumber = "MNO345" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "VLUR4X20009048066", RegNumber = "PQR678" },
                new Vehicle() { Id = Guid.NewGuid(), Vin = "YS2R4X20005387055", RegNumber = "STU901" }
                );
        }
    }
}
