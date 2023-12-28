using System;
using Microsoft.EntityFrameworkCore;
using EquipmentStorage.Data.Models;

namespace EquipmentStorage.Data
{
	public class EquipmentStorageContext:DbContext
	{
        public DbSet<Booking> Booking { get; set; }
        public DbSet<CategoryEquipment> CategoryEquipment { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<StatusBooking> StatusBooking { get; set; }
        public DbSet<UserAuth> UserAuth { get; set; }
        public DbSet<UserDescription> UserDescriptions { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); optionsBuilder.UseNpgsql(@"Host=localhost;port=5432;Database=EquipmentStorage;Username=postgres;Password=0809")
                .UseSnakeCaseNamingConvention()
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())).EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<CategoryEquipment>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Condition>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Equipment>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Interest>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<StatusBooking>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UserAuth>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UserDescription>().Property(p => p.Id).ValueGeneratedOnAdd();



            modelBuilder.Entity<UserAuth>().HasOne(u=> u.Role).WithMany(r => r.Users);
            modelBuilder.Entity<UserDescription>().HasMany(u=>u.Interests).WithMany(u=>u.Users);
            modelBuilder.Entity<UserDescription>().HasMany(u => u.Bookings).WithOne(b => b.User);
            modelBuilder.Entity<UserDescription>().HasOne(u => u.Role);
            modelBuilder.Entity<Booking>().HasOne(b => b.Equipment);
            modelBuilder.Entity<Booking>().HasOne(b => b.StatusBooking).WithMany(s=>s.Bookings);
            modelBuilder.Entity<Equipment>().HasOne(e=> e.CategoryEquipment).WithMany(c=>c.Equipments);
            modelBuilder.Entity<Equipment>().HasOne(e => e.Condition).WithMany(c => c.Equipments);

        }

    }
}

