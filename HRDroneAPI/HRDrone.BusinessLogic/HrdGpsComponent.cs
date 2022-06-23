using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdGpsComponent
    {
        public HrdGps Insert(HrdGps item)
        {
            HrdGps data = new HrdGps();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Long = item.Long;
                data.Lat = item.Lat;
                data.Date = item.Date;
                data.Time = item.Time;
                data.dateTime = item.dateTime;
                data.heightMSL = item.heightMSL;
                data.hDOP = item.hDOP;
                data.pDOP = item.pDOP;
                data.sAcc = item.sAcc;
                data.numGPS = item.numGPS;
                data.numGLNAS = item.numGLNAS;
                data.numSV = item.numSV;
                data.velNorthEastDown = item.velNorthEastDown;

                context.HrdGps!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdGps item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdGps!.Where(x => x.GpsId == item.GpsId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Long = item.Long;
                    data.Lat = item.Lat;
                    data.Date = item.Date;
                    data.Time = item.Time;
                    data.dateTime = item.dateTime;
                    data.heightMSL = item.heightMSL;
                    data.hDOP = item.hDOP;
                    data.pDOP = item.pDOP;
                    data.sAcc = item.sAcc;
                    data.numGPS = item.numGPS;
                    data.numGLNAS = item.numGLNAS;
                    data.numSV = item.numSV;
                    data.velNorthEastDown = item.velNorthEastDown;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdGps { GpsId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdGps GetDataById(int? Id)
        {
            HrdGps obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdGps!.Where(x => x.GpsId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}

