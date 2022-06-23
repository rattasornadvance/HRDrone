using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
 public class HrdRc
    {
        public int RcId { get; set; }
        public int TrackingId { get; set; }
        public string? Aileron { get; set; }
        public string? Elevator { get; set; }
        public string? Rudder { get; set; }
        public string? Throttle { get; set; }
        public string? ModeSwitch { get; set; }
        public string? sigStrength { get; set; }
        public string? failSafe { get; set; }
        public string? dataLost { get; set; }
        public string? appLost { get; set; }
        public string? connected { get; set; }

    }
}
