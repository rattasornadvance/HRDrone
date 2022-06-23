using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdMotorpwrcalcsComponent
    {
        public HrdMotorpwrcalcs Insert(HrdMotorpwrcalcs item)
        {
            HrdMotorpwrcalcs data = new HrdMotorpwrcalcs();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.VoltsAvg = item.VoltsAvg;
                data.VoltsAvgAll = item.VoltsAvgAll;
                data.CurrentAvg = item.CurrentAvg;
                data.CurrentAvgAll = item.CurrentAvgAll;
                data.WattsAvg = item.WattsAvg;
                data.WattsAvgAll = item.WattsAvgAll;
                data.WattSecs = item.WattSecs;
                data.WattSecsAll = item.WattSecsAll;
                data.WattSecsDist = item.WattSecsDist;
                data.WattSecsDistAll = item.WattSecsDistAll;
                data.WattSecsTotalDist = item.WattSecsTotalDist;
                data.WattSecsTotalDistAll = item.WattSecsTotalDistAll;
                data.WattsVelH = item.WattsVelH;
                data.WattsVelHAll = item.WattsVelHAll;
                data.WattsVelD = item.WattsVelD;
                data.WattsVelDAll = item.WattsVelDAll;

                context.HrdMotorpwrcalcs!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdMotorpwrcalcs item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdMotorpwrcalcs!.Where(x => x.MotorpwrcalcsId == item.MotorpwrcalcsId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.VoltsAvg = item.VoltsAvg;
                    data.VoltsAvgAll = item.VoltsAvgAll;
                    data.CurrentAvg = item.CurrentAvg;
                    data.CurrentAvgAll = item.CurrentAvgAll;
                    data.WattsAvg = item.WattsAvg;
                    data.WattsAvgAll = item.WattsAvgAll;
                    data.WattSecs = item.WattSecs;
                    data.WattSecsAll = item.WattSecsAll;
                    data.WattSecsDist = item.WattSecsDist;
                    data.WattSecsDistAll = item.WattSecsDistAll;
                    data.WattSecsTotalDist = item.WattSecsTotalDist;
                    data.WattSecsTotalDistAll = item.WattSecsTotalDistAll;
                    data.WattsVelH = item.WattsVelH;
                    data.WattsVelHAll = item.WattsVelHAll;
                    data.WattsVelD = item.WattsVelD;
                    data.WattsVelDAll = item.WattsVelDAll;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdMotorpwrcalcs { MotorpwrcalcsId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdMotorpwrcalcs GetDataById(int? Id)
        {
            HrdMotorpwrcalcs obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdMotorpwrcalcs!.Where(x => x.MotorpwrcalcsId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
