using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirplaneAPI.Models {
    public class Flight {
        public int FlightId { get; set; }
        public string AirCraftType { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
