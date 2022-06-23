using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdMotorctrl
    {
        public int MotorctrlId { get; set; }
        public int TrackingId { get; set; }
        public string? MotorCtrlStatus { get; set; }
        public string? PWM { get; set; }
    }
}
