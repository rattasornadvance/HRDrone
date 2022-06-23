using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
   public class HrdMvo
    {
        public int MovId { get; set; }
        public int TrackingId { get; set; }
        public string? vel { get; set; }
        public string? pos { get; set; }
        public string? hoverPointUncertainty1 { get; set; }
        public string? hoverPointUncertainty2 { get; set; }
        public string? hoverPointUncertainty3 { get; set; }
        public string? hoverPointUncertainty4 { get; set; }
        public string? hoverPointUncertainty5 { get; set; }
        public string? hoverPointUncertainty6 { get; set; }
        public string? velocityUncertainty1 { get; set; }
        public string? velocityUncertainty2 { get; set; }
        public string? velocityUncertainty3 { get; set; }
        public string? velocityUncertainty4 { get; set; }
        public string? velocityUncertainty5 { get; set; }
        public string? velocityUncertainty6 { get; set; }
        public string? height { get; set; }
        public string? heightUncertainty { get; set; }

    }
}
