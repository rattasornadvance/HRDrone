
namespace HRDrone.Entity
{
    public class HrdAircraftcondition
    {
        public int AirCraftConditionID { get; set; }
        public int TrackingId { get; set; }
        public string? int_fsm { get; set; }
        public string? last_fsm { get; set; }
        public string? UP_state { get; set; }
        public string? safe_fltr { get; set; }
        public string? launch_acc_dur { get; set; }
        public string? launch_free_fall_dur { get; set; }
        public string? launch_free_fall_delta_v { get; set; }
        public string? thrust { get; set; }
        public string? gyro { get; set; }
        public string? land_dur_press { get; set; }
        public string? land_dur_sonic { get; set; }
        public string? thrust_body { get; set; }
        public string? thrust_gnd { get; set; }
        public string? thrust_gnd_compen { get; set; }
        public string? safe_tilt_raw { get; set; }
        public string? sat_timer { get; set; }
        public string? fsmState { get; set; }
        public string? landState { get; set; }
        public string? UP_acc_t { get; set; }
        public string? UP_TF_t { get; set; }
        public string? craft_flight_mode { get; set; }
        public string? launch_acc_duration { get; set; }
        public string? launch_delta_v { get; set; }
        public string? launch_state { get; set; }
        public string? thrust_proj_gnd { get; set; }
        public string? thrust_proj_gnd_compen { get; set; }
        public string? thrust_compensator { get; set; }
        public string? hover_thrust { get; set; }
        public string? dynamic_thrust { get; set; }
        public string? cos_safe_tilt { get; set; }
        public string? safe_tilt { get; set; }
        public string? nearGround { get; set; }
        public string? gyro_acc { get; set; }
        public string? land_dur { get; set; }

    }
}