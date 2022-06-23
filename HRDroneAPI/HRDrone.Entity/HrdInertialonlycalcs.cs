using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Entity
{
    public class HrdInertialonlycalcs
    {
        public int InertialonlycalcsId { get; set; }
        public int TrackingId { get; set; }
        public string? VelNorthEastDown { get; set; }
        public string? PoslNorthEastDown { get; set; }
        public string? agNorthEastDown { get; set; }
        public string? abNorthEastDown { get; set; }
        public string? VeIN_vgX { get; set; }
        public string? VE_vgY { get; set; }
        public string? Vd_vgZ { get; set; }

    }
}