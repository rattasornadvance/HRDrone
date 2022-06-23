using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdMotorctrlComponent
    {
        public HrdMotorctrl Insert(HrdMotorctrl item)
        {
            HrdMotorctrl data = new HrdMotorctrl();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.MotorCtrlStatus = item.MotorCtrlStatus;
                data.PWM = item.PWM;
                context.HrdMotorctrl!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdMotorctrl item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdMotorctrl!.Where(x => x.MotorctrlId == item.MotorctrlId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.MotorCtrlStatus = item.MotorCtrlStatus;
                    data.PWM = item.PWM;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdMotorctrl { MotorctrlId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdMotorctrl GetDataById(int? Id)
        {
            HrdMotorctrl obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdMotorctrl!.Where(x => x.MotorctrlId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
