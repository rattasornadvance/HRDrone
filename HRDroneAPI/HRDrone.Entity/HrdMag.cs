using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdMag
    {
        public int MagId { get; set; }
        public int TrackingId { get; set; }
        public string? Mod { get; set; }
        public string? magYaw { get; set; }
        public string? Yaw_magYaw { get; set; }
        public string? raw { get; set; }
        public string? rawMod { get; set; }

    }
}
