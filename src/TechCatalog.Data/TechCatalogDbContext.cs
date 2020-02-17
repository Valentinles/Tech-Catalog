using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TechCatalog.Models;

namespace TechCatalog.Data
{
    public partial class TechCatalogDbContext : DbContext
    {
        public TechCatalogDbContext()
        {
        }

        public TechCatalogDbContext(DbContextOptions<TechCatalogDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirConditioner> AirConditioners { get; set; }
        public virtual DbSet<Cooker> Cookers { get; set; }
        public virtual DbSet<DesktopPc> DesktopPcs { get; set; }
        public virtual DbSet<GameConsole> GameConsoles { get; set; }
        public virtual DbSet<Headphone> Headphones { get; set; }
        public virtual DbSet<Keyboard> Keyboards { get; set; }
        public virtual DbSet<Laptop> Laptops { get; set; }
        public virtual DbSet<Mouse> Mice { get; set; }
        public virtual DbSet<MobilePhone> MobilePhones { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Refrigerator> Refrigerators { get; set; }
        public virtual DbSet<Tablet> Tablets { get; set; }
        public virtual DbSet<Tv> Tvs { get; set; }
        public virtual DbSet<WashingMachine> WashingMachines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirConditioner>(entity =>
            {
                entity.Property(e => e.CapacityCooling).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CapacityHeating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PowerConsumptionCooling).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PowerConsumptionHeating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cooker>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DesktopPc>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProcessorSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<GameConsole>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Headphone>(entity =>
            {
                entity.Property(e => e.CableLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Keyboard>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.Property(e => e.DisplaySizeInch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProcessorSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Mouse>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MobilePhone>(entity =>
            {
                entity.Property(e => e.DisplaySizeInch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.Property(e => e.DisplaySizeInch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Refrigerator>(entity =>
            {
                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Tablet>(entity =>
            {
                entity.Property(e => e.DisplaySizeInch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Tv>(entity =>
            {
                entity.Property(e => e.DisplaySizeInch).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<WashingMachine>(entity =>
            {
                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WashingCapacity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
