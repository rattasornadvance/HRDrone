using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdAircompComponent
    {
        public HrdAircomp Insert(HrdAircomp item)
        {
            HrdAircomp data = new HrdAircomp();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.AirSpeedBodyX = item.AirSpeedBodyX;
                data.AirSpeedBodyY = item.AirSpeedBodyY;
                data.Alti = item.Alti;
                data.VelNorm = item.VelNorm;
                data.VelTime1 = item.VelTime1;
                data.VelTime2 = item.VelTime2;
                data.VelLevel = item.VelLevel;
                data.WindSpeed = item.WindSpeed;
                data.WindX = item.WindX;
                data.WindY = item.WindY;
                data.MotorSpeed = item.MotorSpeed;
                data.WindHeading = item.WindHeading;
                data.WindMagnitude = item.WindMagnitude;
                data.WindMagnitude2 = item.WindMagnitude2;
                context.HrdAircomp!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdAircomp item)
        {
            using (var context = new HrdContext())
            {
                var obj = context.HrdAircomp!.Where(x => x.AircompId == item.AircompId).FirstOrDefault();
                if (obj != null)
                {
                    obj.TrackingId = item.TrackingId;
                    obj.AirSpeedBodyX = item.AirSpeedBodyX;
                    obj.AirSpeedBodyY = item.AirSpeedBodyY;
                    obj.Alti = item.Alti;
                    obj.VelNorm = item.VelNorm;
                    obj.VelTime1 = item.VelTime1;
                    obj.VelTime2 = item.VelTime2;
                    obj.VelLevel = item.VelLevel;
                    obj.WindSpeed = item.WindSpeed;
                    obj.WindX = item.WindX;
                    obj.WindY = item.WindY;
                    obj.MotorSpeed = item.MotorSpeed;
                    obj.WindHeading = item.WindHeading;
                    obj.WindMagnitude = item.WindMagnitude;
                    obj.WindMagnitude2 = item.WindMagnitude2;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdAircomp { AircompId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdAircomp GetDataById(int? Id)
        {
            HrdAircomp obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdAircomp!.Where(x => x.AircompId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
