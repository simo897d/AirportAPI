using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirplaneAPI.Models;

namespace AirplaneAPI.Data {
    public class FlightData : DbContext {
        public FlightData(DbContextOptions<FlightData> options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<Flight> Flights { get; set; }
    }
}
