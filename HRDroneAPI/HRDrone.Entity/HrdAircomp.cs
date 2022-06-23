using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdAircomp
    {
        public int AircompId { get; set; }
        public int TrackingId { get; set; }
        public string? AirSpeedBodyX { get; set; }
        public string? AirSpeedBodyY { get; set; }
        public string? Alti { get; set; }
        public string? VelNorm { get; set; }
        public string? VelTime1 { get; set; }
        public string? VelTime2 { get; set; }
        public string? VelLevel { get; set; }
        public string? WindSpeed { get; set; }
        public string? WindX { get; set; }
        public string? WindY { get; set; }
        public string? MotorSpeed { get; set; }
        public string? WindHeading { get; set; }
        public string? WindMagnitude { get; set; }
        public string? WindMagnitude2 { get; set; }

    }
}