using AM.ApplicationCore.Domain;
using AM.Infrastructure.Conf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext:DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staff{ get; set; }
        public DbSet<Traveller> Travelers{ get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=RacemBenAmarDB;Integrated Security=true"
            );
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.Entity<Staff>().ToTable("staff");
            modelBuilder.Entity<Traveller>().ToTable("traveller");
        }

            protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            modelConfigurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }
    }


    }

