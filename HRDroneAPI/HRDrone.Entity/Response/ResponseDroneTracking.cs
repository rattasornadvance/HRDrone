using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity.Response
{
    public class ResponseDroneTracking
    {
        public int code { get; set; }
        public string message { get; set; } = "";
        public object? resultJson { get; set; }
    }
}
