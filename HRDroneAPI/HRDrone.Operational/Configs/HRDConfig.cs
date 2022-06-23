using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDrone.Operational.Configs
{
    public class HRDConfig
    {
        public static string ConnectionString { get; set; } = @"server=.\SQL2017; database=HRB_DRONE;User ID=sa;Password=pwd0001; Persist Security Info=false;Connection Timeout=30;";
        public static bool KeepLog { get; set; }
        public static string KeepLogPath { get; set; } = string.Empty;
        public static string NLS { get; set; } = string.Empty;
        public static int TimeInterval { get; set; }
    }
}
