using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdMotorpwrcalcs
    {
        public int MotorpwrcalcsId { get; set; }
        public int TrackingId { get; set; }
        public string? VoltsAvg { get; set; }
        public string? VoltsAvgAll { get; set; }
        public string? CurrentAvg { get; set; }
        public string? CurrentAvgAll { get; set; }
        public string? WattsAvg { get; set; }
        public string? WattsAvgAll { get; set; }
        public string? WattSecs { get; set; }
        public string? WattSecsAll { get; set; }
        public string? WattSecsDist { get; set; }
        public string? WattSecsDistAll { get; set; }
        public string? WattSecsTotalDist { get; set; }
        public string? WattSecsTotalDistAll { get; set; }
        public string? WattsVelH { get; set; }
        public string? WattsVelHAll { get; set; }
        public string? WattsVelD { get; set; }
        public string? WattsVelDAll { get; set; }

    }
}
