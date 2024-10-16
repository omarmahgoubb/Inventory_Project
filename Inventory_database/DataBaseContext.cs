using Inventory_Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Data_base
{
    public class DataBaseContext : IdentityDbContext<IdentityUser>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure base IdentityDbContext configurations are applied
            base.OnModelCreating(modelBuilder);

            // Seed roles for Identity
            modelBuilder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                 new IdentityRole
                 {
                     Id = Guid.NewGuid().ToString(),
                     Name = "Viewer",
                     NormalizedName = "viewer",
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                 },
                   new IdentityRole
                   {
                       Id = Guid.NewGuid().ToString(),
                       Name = "Supplier",
                       NormalizedName = "supplier",
                       ConcurrencyStamp = Guid.NewGuid().ToString(),
                   }
            );
        }
    }
}