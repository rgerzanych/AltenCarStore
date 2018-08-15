using System.Data.Entity;
using AltenCarStore.Infrastructure.DAL;
using AltenCarStore.VehicleService.Data.Abstractions;
using AltenCarStore.VehicleService.Domain;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AltenCarStore.VehicleService.Data
{
    [DbConfigurationType(typeof(CloudStorageConfiguration))]
    public class VehiclesContext : DbContext, IVehiclesContext
    {
        public System.Data.Entity.DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .ToTable("Vehicles");
            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.Id)
                .HasColumnName("VehicleID")
                .HasColumnType("uniqueidentifier");
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.RegNumber)
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10)
                .IsRequired();
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.Vin)
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
