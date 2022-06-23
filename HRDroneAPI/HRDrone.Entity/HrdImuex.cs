using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdImuex
    {
        public int ImuexId { get; set; }
        public int TrackingId { get; set; }
        public string? vo_v { get; set; }
        public string? vo_p { get; set; }
        public string? us_v { get; set; }
        public string? us_p { get; set; }
        public string? vo_flag_Navi { get; set; }
        public string? cnt { get; set; }
        public string? rtk_Longitude { get; set; }
        public string? rtk_Latitude { get; set; }
        public string? rtk_Alti { get; set; }
        public string? err { get; set; }

    }
}
