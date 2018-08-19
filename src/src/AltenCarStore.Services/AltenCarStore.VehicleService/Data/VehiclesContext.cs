using AltenCarStore.VehicleService.Data.Abstractions;
using AltenCarStore.VehicleService.Domain;
using AltenCarStore.VehicleService.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AltenCarStore.VehicleService.Data
{
    public class VehiclesContext : DbContext, IVehiclesContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("Customers");
            modelBuilder.Entity<Customer>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Customer>()
                .Property(v => v.Id)
                .HasColumnName("CustomerID")
                .HasColumnType("uniqueidentifier");
            modelBuilder.Entity<Customer>()
                .Property(v => v.Name)
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Customer>()
                .Property(v => v.Address)
                .HasColumnType("nvarchar(250)")
                .HasMaxLength(250)
                .IsRequired();

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
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.OwnerId)
                .HasColumnName("OwnerID")
                .HasColumnType("uniqueidentifier");

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Owner)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.OwnerId);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Vehicles)
                .WithOne();

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
