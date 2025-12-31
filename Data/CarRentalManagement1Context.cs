using CarRentalManagement1.Configurations.Entities;
using CarRentalManagement1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement1.Data
{
    public class CarRentalManagement1Context : DbContext
    {
        public CarRentalManagement1Context (DbContextOptions<CarRentalManagement1Context> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement1.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
