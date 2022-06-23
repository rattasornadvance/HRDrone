using System.Data;

namespace HRDrone.Entity
{
    public class HrdTracking
    {
        public int TrackingId { get; set; }
        public int RegId { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public string? Height { get; set; }
        public string? BatterLv { get; set; }
        public string? Speed { get; set; }
        public string? Latitude { get; set; }
        public string? Longittude { get; set; }
        public HrdTracking fromMap(DataTable data)
        {
            if (data.Rows.Count == 0) return new HrdTracking();
            return new HrdTracking
            {
                TrackingId = Convert.ToInt32(data.Rows[0]["TRACKING_ID"]),
                RegId = Convert.ToInt32(data.Rows[0]["REG_ID"]),
                StartDatetime = Convert.ToDateTime(data.Rows[0]["START_DATETIME"]),
                EndDatetime = Convert.ToDateTime(data.Rows[0]["END_DATETIME"]),
            };
        }
    }
}
