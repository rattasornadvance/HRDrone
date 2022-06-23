using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdRcComponent
    {
        public HrdRc Insert(HrdRc item)
        {
            HrdRc data = new HrdRc();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Aileron = item.Aileron;
                data.Elevator = item.Elevator;
                data.Rudder = item.Rudder;
                data.Throttle = item.Throttle;
                data.ModeSwitch = item.ModeSwitch;
                data.sigStrength = item.sigStrength;
                data.failSafe = item.failSafe;
                data.dataLost = item.dataLost;
                data.appLost = item.appLost;
                data.connected = item.connected;

                context.HrdRc!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdRc item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdRc!.Where(x => x.RcId == item.RcId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Aileron = item.Aileron;
                    data.Elevator = item.Elevator;
                    data.Rudder = item.Rudder;
                    data.Throttle = item.Throttle;
                    data.ModeSwitch = item.ModeSwitch;
                    data.sigStrength = item.sigStrength;
                    data.failSafe = item.failSafe;
                    data.dataLost = item.dataLost;
                    data.appLost = item.appLost;
                    data.connected = item.connected;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdRc { RcId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdRc GetDataById(int? Id)
        {
            HrdRc obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdRc!.Where(x => x.RcId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
