using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdGeneralComponent
    {
        public HrdGeneral Insert(HrdGeneral item)
        {
            HrdGeneral data = new HrdGeneral();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.relativeHeight = item.relativeHeight;
                data.absoluteHeight = item.absoluteHeight;
                data.flightTime = item.flightTime;
                data.gpsHealth = item.gpsHealth;
                data.vpsHeight = item.vpsHeight;
                data.flyCState = item.flyCState;
                data.flycCommand = item.flycCommand;
                data.flightAction = item.flightAction;
                data.nonGPSCause = item.nonGPSCause;
                data.connectedToRC = item.connectedToRC;
                data.gpsUsed = item.gpsUsed;
                data.visionUsed = item.visionUsed;
                data.CreatedOn = item.CreatedOn;
                context.HrdGeneral!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdGeneral item)
        {
            using (var context = new HrdContext())
            {
                var obj = context.HrdGeneral!.Where(x => x.GeneralId == item.GeneralId).FirstOrDefault();
                if (obj != null)
                {
                    obj.TrackingId = item.TrackingId;
                    obj.relativeHeight = item.relativeHeight;
                    obj.absoluteHeight = item.absoluteHeight;
                    obj.flightTime = item.flightTime;
                    obj.gpsHealth = item.gpsHealth;
                    obj.vpsHeight = item.vpsHeight;
                    obj.flyCState = item.flyCState;
                    obj.flycCommand = item.flycCommand;
                    obj.flightAction = item.flightAction;
                    obj.nonGPSCause = item.nonGPSCause;
                    obj.connectedToRC = item.connectedToRC;
                    obj.gpsUsed = item.gpsUsed;
                    obj.visionUsed = item.visionUsed;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdGeneral { GeneralId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdGeneral GetDataById(int? Id)
        {
            HrdGeneral obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdGeneral!.Where(x => x.GeneralId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}