using HRDrone.Database;
using HRDrone.Entity;


namespace HRDrone.BusinessLogic
{
    public class HrdControllerComponent
    {
        public HrdController Insert(HrdController item)
        {
            HrdController data = new HrdController();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.gpsLevel = item.gpsLevel;
                data.ctrl_level = item.ctrl_level;
                context.HrdController!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdController item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdController!.Where(x => x.ControllerId == item.ControllerId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.gpsLevel = item.gpsLevel;
                    data.ctrl_level = item.ctrl_level;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdController { ControllerId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdController GetDataById(int? Id)
        {
            HrdController obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdController!.Where(x => x.ControllerId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
