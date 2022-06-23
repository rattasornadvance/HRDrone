using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdSmartBatt
    {
        public int SmartBattId { get; set; }
        public int TrackingId { get; set; }
        public string? goHomePercentage { get; set; }
        public string? landPercentage { get; set; }
        public string? goHomeTime { get; set; }
        public string? landTime { get; set; }
        public string? voltagePercentage { get; set; }
        public string? smartBattStatus { get; set; }
        public string? GHStatus { get; set; }

    }
}

   