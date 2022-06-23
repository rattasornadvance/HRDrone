using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdHpComponent
    {
        public HrdHp Insert(HrdHp item)
        {
            HrdHp data = new HrdHp();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Longitude = item.Longitude;
                data.Latitude = item.Latitude;
                data.Altitude = item.Altitude;
                data.rthHeight = item.rthHeight;

                context.HrdHp!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdHp item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdHp!.Where(x => x.HpId == item.HpId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Longitude = item.Longitude;
                    data.Latitude = item.Latitude;
                    data.Altitude = item.Altitude;
                    data.rthHeight = item.rthHeight;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdHp { HpId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdHp GetDataById(int? Id)
        {
            HrdHp obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdHp!.Where(x => x.HpId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}

