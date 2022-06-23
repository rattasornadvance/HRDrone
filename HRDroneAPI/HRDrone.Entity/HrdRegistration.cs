using System.Data;

namespace HRDrone.Entity
{
  public class HrdRegistration
    {
        public int RegId { get; set; }
        public string? DroneUid { get; set; }
        public string? DroneName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public HrdRegistration fromMap(DataTable data)
        {
            if (data.Rows.Count == 0) return new HrdRegistration();
            return new HrdRegistration
            {
                RegId = Convert.ToInt32(data.Rows[0]["REG_ID"]),
                DroneUid = data.Rows[0]["DRONE_UID"].ToString(),
                DroneName = data.Rows[0]["DRONE_NAME"].ToString(),
                CreatedOn = Convert.ToDateTime(data.Rows[0]["CREATED_ON"]),
            };
        }
    }
}
