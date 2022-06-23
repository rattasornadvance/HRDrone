using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdTrackingComponent
    {
        public HrdTracking Insert(HrdTracking item)
        {
            HrdTracking data = new HrdTracking();
            using (var context = new HrdContext())
            {
                data.RegId = item.RegId;
                data.StartDatetime = item.StartDatetime;
                data.EndDatetime = item.EndDatetime;

                context.HrdTracking!.Add(data);
                context.SaveChanges();
            }
            return data;
        }
        public void Update(HrdTracking item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdTracking!.Where(x => x.TrackingId == item.TrackingId).FirstOrDefault();
                if (data != null)
                {
                    data.RegId = item.RegId;
                    data.StartDatetime = item.StartDatetime;
                    data.EndDatetime = item.EndDatetime;
                    context.SaveChanges();
                }
            }
        }
        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdTracking { TrackingId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }
        public HrdTracking GetDataById(int? Id)
        {
            HrdTracking obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdTracking!.Where(x => x.TrackingId == Id).FirstOrDefault()!;
            }
            return obj;
        }
        public HrdTracking GetDataLastestByRegId(int? regId)
        {
            HrdTracking obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdTracking!.Where(x => x.RegId == regId).OrderByDescending(s => s.TrackingId).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
