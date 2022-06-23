using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdMotor
    {
        public int MotorId { get; set; }
        public int TrackingId { get; set; }
        public string? Speed { get; set; }
        public string? EscTemp { get; set; }
        public string? PPMrecv { get; set; }
        public string? V_out { get; set; }
        public string? Volts { get; set; }
        public string? MotorCurrent { get; set; }
        public string? MotorStatus { get; set; }
        public string? PPMsend { get; set; }
        public string? thrustAngle { get; set; }

    }
}

