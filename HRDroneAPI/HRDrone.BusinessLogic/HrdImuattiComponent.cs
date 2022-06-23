using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdImuattiComponent
    {
        public HrdImuatti Insert(HrdImuatti item)
        {
            HrdImuatti data = new HrdImuatti();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Longitude = item.Longitude;
                data.Latitude = item.Latitude;
                data.barometerRaw = item.barometerRaw;
                data.barometerSmooth = item.barometerSmooth;
                data.accelAxis = item.accelAxis;
                data.accelComposite = item.accelComposite;
                data.gyroAxis = item.gyroAxis;
                data.gyroComposite = item.gyroComposite;
                data.magAxis = item.magAxis;
                data.magMod = item.magMod;
                data.VelNorthEastDown = item.VelNorthEastDown;
                data.velComposite = item.velComposite;
                data.velH = item.velH;
                data.GPS_H = item.GPS_H;
                data.quatWXYZ = item.quatWXYZ;
                data.roll = item.roll;
                data.pitch = item.pitch;
                data.yaw = item.yaw;
                data.yaw360 = item.yaw360;
                data.totalGyroAxis = item.totalGyroAxis;
                data.magYaw = item.magYaw;
                data.Yaw_magYaw = item.Yaw_magYaw;
                data.distanceHP = item.distanceHP;
                data.distanceTravelled = item.distanceTravelled;
                data.directionOfTravelMag = item.directionOfTravelMag;
                data.directionOfTravelTrue = item.directionOfTravelTrue;
                data.temperature = item.temperature;
                data.ag_Axis = item.ag_Axis;
                data.gb_Axis = item.gb_Axis;

                context.HrdImuatti!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdImuatti item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdImuatti!.Where(x => x.ImuId == item.ImuId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Longitude = item.Longitude;
                    data.Latitude = item.Latitude;
                    data.barometerRaw = item.barometerRaw;
                    data.barometerSmooth = item.barometerSmooth;
                    data.accelAxis = item.accelAxis;
                    data.accelComposite = item.accelComposite;
                    data.gyroAxis = item.gyroAxis;
                    data.gyroComposite = item.gyroComposite;
                    data.magAxis = item.magAxis;
                    data.magMod = item.magMod;
                    data.VelNorthEastDown = item.VelNorthEastDown;
                    data.velComposite = item.velComposite;
                    data.velH = item.velH;
                    data.GPS_H = item.GPS_H;
                    data.quatWXYZ = item.quatWXYZ;
                    data.roll = item.roll;
                    data.pitch = item.pitch;
                    data.yaw = item.yaw;
                    data.yaw360 = item.yaw360;
                    data.totalGyroAxis = item.totalGyroAxis;
                    data.magYaw = item.magYaw;
                    data.Yaw_magYaw = item.Yaw_magYaw;
                    data.distanceHP = item.distanceHP;
                    data.distanceTravelled = item.distanceTravelled;
                    data.directionOfTravelMag = item.directionOfTravelMag;
                    data.directionOfTravelTrue = item.directionOfTravelTrue;
                    data.temperature = item.temperature;
                    data.ag_Axis = item.ag_Axis;
                    data.gb_Axis = item.gb_Axis;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdImuatti { ImuId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdImuatti GetDataById(int? Id)
        {
            HrdImuatti obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdImuatti!.Where(x => x.ImuId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
