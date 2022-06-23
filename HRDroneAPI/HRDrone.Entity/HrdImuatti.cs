using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdImuatti
    {
        public int ImuId { get; set; }
        public int TrackingId { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? barometerRaw { get; set; }
        public string? barometerSmooth { get; set; }
        public string? accelAxis { get; set; }
        public string? accelComposite { get; set; }
        public string? gyroAxis { get; set; }
        public string? gyroComposite { get; set; }
        public string? magAxis { get; set; }
        public string? magMod { get; set; }
        public string? VelNorthEastDown { get; set; }
        public string? velComposite { get; set; }
        public string? velH { get; set; }
        public string? GPS_H { get; set; }
        public string? quatWXYZ { get; set; }
        public string? roll { get; set; }
        public string? pitch { get; set; }
        public string? yaw { get; set; }
        public string? yaw360 { get; set; }
        public string? totalGyroAxis { get; set; }
        public string? magYaw { get; set; }
        public string? Yaw_magYaw { get; set; }
        public string? distanceHP { get; set; }
        public string? distanceTravelled { get; set; }
        public string? directionOfTravelMag { get; set; }
        public string? directionOfTravelTrue { get; set; }
        public string? temperature { get; set; }
        public string? ag_Axis { get; set; }
        public string? gb_Axis { get; set; }

    }
}
