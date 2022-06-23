using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdGeneral
    {
        public int GeneralId { get; set; }
        public int TrackingId { get; set; }    
        public string? relativeHeight { get; set; }
        public string? absoluteHeight { get; set; }
        public string? flightTime { get; set; }
        public string? gpsHealth { get; set; }
        public string? vpsHeight { get; set; }
        public string? flyCState { get; set; }
        public string? flycCommand { get; set; }
        public string? flightAction { get; set; }
        public string? nonGPSCause { get; set; }
        public string? connectedToRC { get; set; }
        public string? gpsUsed { get; set; }
        public string? visionUsed { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
