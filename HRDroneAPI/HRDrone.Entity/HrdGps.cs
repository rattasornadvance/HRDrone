using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdGps
    {
        public int GpsId { get; set; }
        public int TrackingId { get; set; }
        public string? Long { get; set; }
        public string? Lat { get; set; }
        public int? Date { get; set; }
        public int? Time { get; set; }
        public DateTime dateTime { get; set; }
        public string? heightMSL { get; set; }
        public string? hDOP { get; set; }
        public string? pDOP { get; set; }
        public string? sAcc { get; set; }
        public string? numGPS { get; set; }
        public string? numGLNAS { get; set; }
        public string? numSV { get; set; }
        public string? velNorthEastDown { get; set; }
    }
}
