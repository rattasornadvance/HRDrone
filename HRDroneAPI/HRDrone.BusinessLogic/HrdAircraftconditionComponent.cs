using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdAircraftconditionComponent
    {
        public HrdAircraftcondition Insert(HrdAircraftcondition item)
        {
            HrdAircraftcondition data = new HrdAircraftcondition();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.int_fsm = item.int_fsm;
                data.last_fsm = item.last_fsm;
                data.UP_state = item.UP_state;
                data.safe_fltr = item.safe_fltr;
                data.launch_acc_dur = item.launch_acc_dur;
                data.launch_free_fall_dur = item.launch_free_fall_dur;
                data.launch_free_fall_delta_v = item.launch_free_fall_delta_v;
                data.thrust = item.thrust;
                data.gyro = item.gyro;
                data.land_dur_press = item.land_dur_press;
                data.land_dur_sonic = item.land_dur_sonic;
                data.thrust_body = item.thrust_body;
                data.thrust_gnd = item.thrust_gnd;
                data.thrust_gnd_compen = item.thrust_gnd_compen;
                data.safe_tilt_raw = item.safe_tilt_raw;
                data.sat_timer = item.sat_timer;
                data.fsmState = item.fsmState;
                data.landState = item.landState;
                data.UP_acc_t = item.UP_acc_t;
                data.UP_TF_t = item.UP_TF_t;
                data.craft_flight_mode = item.craft_flight_mode;
                data.launch_acc_duration = item.launch_acc_duration;
                data.launch_delta_v = item.launch_delta_v;
                data.launch_state = item.launch_state;
                data.thrust_proj_gnd = item.thrust_proj_gnd;
                data.thrust_proj_gnd_compen = item.thrust_proj_gnd_compen;
                data.thrust_compensator = item.thrust_compensator;
                data.hover_thrust = item.hover_thrust;
                data.dynamic_thrust = item.dynamic_thrust;
                data.cos_safe_tilt = item.cos_safe_tilt;
                data.safe_tilt = item.safe_tilt;
                data.nearGround = item.nearGround;
                data.gyro_acc = item.gyro_acc;
                data.land_dur = item.land_dur;
                context.HrdAircraftcondition!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdAircraftcondition item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdAircraftcondition!.Where(x => x.AirCraftConditionID == item.AirCraftConditionID).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.int_fsm = item.int_fsm;
                    data.last_fsm = item.last_fsm;
                    data.UP_state = item.UP_state;
                    data.safe_fltr = item.safe_fltr;
                    data.launch_acc_dur = item.launch_acc_dur;
                    data.launch_free_fall_dur = item.launch_free_fall_dur;
                    data.launch_free_fall_delta_v = item.launch_free_fall_delta_v;
                    data.thrust = item.thrust;
                    data.gyro = item.gyro;
                    data.land_dur_press = item.land_dur_press;
                    data.land_dur_sonic = item.land_dur_sonic;
                    data.thrust_body = item.thrust_body;
                    data.thrust_gnd = item.thrust_gnd;
                    data.thrust_gnd_compen = item.thrust_gnd_compen;
                    data.safe_tilt_raw = item.safe_tilt_raw;
                    data.sat_timer = item.sat_timer;
                    data.fsmState = item.fsmState;
                    data.landState = item.landState;
                    data.UP_acc_t = item.UP_acc_t;
                    data.UP_TF_t = item.UP_TF_t;
                    data.craft_flight_mode = item.craft_flight_mode;
                    data.launch_acc_duration = item.launch_acc_duration;
                    data.launch_delta_v = item.launch_delta_v;
                    data.launch_state = item.launch_state;
                    data.thrust_proj_gnd = item.thrust_proj_gnd;
                    data.thrust_proj_gnd_compen = item.thrust_proj_gnd_compen;
                    data.thrust_compensator = item.thrust_compensator;
                    data.hover_thrust = item.hover_thrust;
                    data.dynamic_thrust = item.dynamic_thrust;
                    data.cos_safe_tilt = item.cos_safe_tilt;
                    data.safe_tilt = item.safe_tilt;
                    data.nearGround = item.nearGround;
                    data.gyro_acc = item.gyro_acc;
                    data.land_dur = item.land_dur;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdAircraftcondition { AirCraftConditionID = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdAircraftcondition GetDataById(int? Id)
        {
            HrdAircraftcondition obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdAircraftcondition!.Where(x => x.AirCraftConditionID == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
