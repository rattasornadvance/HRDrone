using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdRegistrationComponent
    {
        public HrdRegistration Insert(HrdRegistration item)
        {
            HrdRegistration data = new HrdRegistration();
            using (var context = new HrdContext())
            {
                data.DroneUid = item.DroneUid;
                data.DroneName = item.DroneName;
                data.CreatedOn = item.CreatedOn;

                context.HrdRegistration!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdRegistration item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdRegistration!.Where(x => x.RegId == item.RegId).FirstOrDefault();
                if (data != null)
                {
                    data.DroneUid = item.DroneUid;
                    data.DroneName = item.DroneName;
                    data.CreatedOn = item.CreatedOn;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdRegistration { RegId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }
        public HrdRegistration GetDataById(int? Id)
        {
            HrdRegistration obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdRegistration!.Where(x => x.RegId == Id).FirstOrDefault()!;
            }
            return obj;
        }
        public List<HrdRegistration> GetDataAll()
        {
            List<HrdRegistration> obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdRegistration.ToList();
            }
            return obj;
        }
    }

}