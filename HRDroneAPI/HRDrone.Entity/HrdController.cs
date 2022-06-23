using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdController
    {
        public int ControllerId { get; set; }
        public int TrackingId { get; set; }
        public string? gpsLevel { get; set; }
        public string? ctrl_level { get; set; }
    }
}