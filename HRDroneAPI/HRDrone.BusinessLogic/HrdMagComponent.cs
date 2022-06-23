using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdMagComponent
    {
        public HrdMag Insert(HrdMag item)
        {
            HrdMag data = new HrdMag();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.Mod = item.Mod;
                data.magYaw = item.magYaw;
                data.Yaw_magYaw = item.Yaw_magYaw;
                data.raw = item.raw;
                data.rawMod = item.rawMod;

                context.HrdMag!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdMag item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdMag!.Where(x => x.MagId == item.MagId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.Mod = item.Mod;
                    data.magYaw = item.magYaw;
                    data.Yaw_magYaw = item.Yaw_magYaw;
                    data.raw = item.raw;
                    data.rawMod = item.rawMod;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdMag { MagId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdMag GetDataById(int? Id)
        {
            HrdMag obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdMag!.Where(x => x.MagId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}

