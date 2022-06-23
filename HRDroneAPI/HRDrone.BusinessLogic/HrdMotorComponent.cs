using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdMotorComponent
    {
        public HrdMotor Insert(HrdMotor item)
        {
            HrdMotor data = new HrdMotor();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Speed = item.Speed;
                data.EscTemp = item.EscTemp;
                data.PPMrecv = item.PPMrecv;
                data.V_out = item.V_out;
                data.Volts = item.Volts;
                data.MotorCurrent = item.MotorCurrent;
                data.MotorStatus = item.MotorStatus;
                data.PPMsend = item.PPMsend;
                data.thrustAngle = item.thrustAngle;
                context.HrdMotor!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdMotor item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdMotor!.Where(x => x.MotorId == item.MotorId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Speed = item.Speed;
                    data.EscTemp = item.EscTemp;
                    data.PPMrecv = item.PPMrecv;
                    data.V_out = item.V_out;
                    data.Volts = item.Volts;
                    data.MotorCurrent = item.MotorCurrent;
                    data.MotorStatus = item.MotorStatus;
                    data.PPMsend = item.PPMsend;
                    data.thrustAngle = item.thrustAngle;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdMotor { MotorId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdMotor GetDataById(int? Id)
        {
            HrdMotor obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdMotor!.Where(x => x.MotorId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}


