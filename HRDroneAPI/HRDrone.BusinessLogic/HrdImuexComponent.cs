using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdImuexComponent
    {
        public HrdImuex Insert(HrdImuex item)
        {
            HrdImuex data = new HrdImuex();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.vo_v = item.vo_v;
                data.vo_p = item.vo_p;
                data.us_v = item.us_v;
                data.us_p = item.us_p;
                data.vo_flag_Navi = item.vo_flag_Navi;
                data.cnt = item.cnt;
                data.rtk_Longitude = item.rtk_Longitude;
                data.rtk_Latitude = item.rtk_Latitude;
                data.rtk_Alti = item.rtk_Alti;
                data.err = item.err;

                context.HrdImuex!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdImuex item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdImuex!.Where(x => x.ImuexId == item.ImuexId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.vo_v = item.vo_v;
                    data.vo_p = item.vo_p;
                    data.us_v = item.us_v;
                    data.us_p = item.us_p;
                    data.vo_flag_Navi = item.vo_flag_Navi;
                    data.cnt = item.cnt;
                    data.rtk_Longitude = item.rtk_Longitude;
                    data.rtk_Latitude = item.rtk_Latitude;
                    data.rtk_Alti = item.rtk_Alti;
                    data.err = item.err;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdImuex { ImuexId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdImuex GetDataById(int? Id)
        {
            HrdImuex obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdImuex!.Where(x => x.ImuexId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
