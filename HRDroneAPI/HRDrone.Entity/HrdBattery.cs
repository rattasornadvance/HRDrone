using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdBattery
    {
        public int BatteryId { get; set; }
        public int TrackingId { get; set; }
        public int? lowVoltage { get; set; }
        public string? status { get; set; }
        public string? cellVolts { get; set; }
        public string? batteryCurrent { get; set; }
        public string? totalVolts { get; set; }
        public string? Temp { get; set; }
        public string? batteryPercentage_FullChargeCap { get; set; }
        public string? batteryPercentage_RemainingCap { get; set; }
        public string? batteryPercentage_voltSpread { get; set; }
        public string? watts_minCurrent { get; set; }
        public string? watts_maxCurrent { get; set; }
        public string? watts_avgCurrent { get; set; }
        public string? watts_minVolts { get; set; }
        public string? watts_maxVolts { get; set; }
        public string? watts_avgVolts { get; set; }
        public string? watts_minWatts { get; set; }
        public string? watts_maxWatts { get; set; }
        public string? watts_avgWatts { get; set; }

    }
}