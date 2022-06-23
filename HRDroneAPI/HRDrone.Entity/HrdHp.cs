using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdHp
    {
        public int HpId { get; set; }
        public int TrackingId { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? Altitude { get; set; }
        public string? rthHeight { get; set; }
    }
}
