using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
 public class HrdOa
    {
        public int OaId { get; set; }
        public int TrackingId { get; set; }
        public string? avoidObst { get; set; }
        public string? emergBrake { get; set; }
        public string? radiusLimit { get; set; }
        public string? airportLimit { get; set; }
        public string? groundForceLanding { get; set; }
        public string? horizNearBoundary { get; set; }
        public string? vertLowLimit { get; set; }
        public string? vertAirportLimit { get; set; }
        public string? roofLimit { get; set; }
        public string? hitGroundLimit { get; set; }
        public string? frontDistance { get; set; }

    }
}
