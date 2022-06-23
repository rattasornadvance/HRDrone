using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdSmartBattComponent
    {
        public HrdSmartBatt Insert(HrdSmartBatt item)
        {
            HrdSmartBatt data = new HrdSmartBatt();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.goHomePercentage = item.goHomePercentage;
                data.landPercentage = item.landPercentage;
                data.goHomeTime = item.goHomeTime;
                data.landTime = item.landTime;
                data.voltagePercentage = item.voltagePercentage;
                data.smartBattStatus = item.smartBattStatus;
                data.GHStatus = item.GHStatus;

                context.HrdSmartBatt!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdSmartBatt item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdSmartBatt!.Where(x => x.SmartBattId == item.SmartBattId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.goHomePercentage = item.goHomePercentage;
                    data.landPercentage = item.landPercentage;
                    data.goHomeTime = item.goHomeTime;
                    data.landTime = item.landTime;
                    data.voltagePercentage = item.voltagePercentage;
                    data.smartBattStatus = item.smartBattStatus;
                    data.GHStatus = item.GHStatus;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdSmartBatt { SmartBattId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdSmartBatt GetDataById(int? Id)
        {
            HrdSmartBatt obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdSmartBatt!.Where(x => x.SmartBattId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
