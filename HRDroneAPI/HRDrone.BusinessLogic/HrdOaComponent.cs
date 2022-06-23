using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdOaComponent
    {
        public HrdOa Insert(HrdOa item)
        {
            HrdOa data = new HrdOa();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.avoidObst = item.avoidObst;
                data.emergBrake = item.emergBrake;
                data.radiusLimit = item.radiusLimit;
                data.airportLimit = item.airportLimit;
                data.groundForceLanding = item.groundForceLanding;
                data.horizNearBoundary = item.horizNearBoundary;
                data.vertLowLimit = item.vertLowLimit;
                data.vertAirportLimit = item.vertAirportLimit;
                data.roofLimit = item.roofLimit;
                data.hitGroundLimit = item.hitGroundLimit;
                data.frontDistance = item.frontDistance;

                context.HrdOa!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdOa item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdOa!.Where(x => x.OaId == item.OaId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.avoidObst = item.avoidObst;
                    data.emergBrake = item.emergBrake;
                    data.radiusLimit = item.radiusLimit;
                    data.airportLimit = item.airportLimit;
                    data.groundForceLanding = item.groundForceLanding;
                    data.horizNearBoundary = item.horizNearBoundary;
                    data.vertLowLimit = item.vertLowLimit;
                    data.vertAirportLimit = item.vertAirportLimit;
                    data.roofLimit = item.roofLimit;
                    data.hitGroundLimit = item.hitGroundLimit;
                    data.frontDistance = item.frontDistance;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdOa { OaId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdOa GetDataById(int? Id)
        {
            HrdOa obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdOa!.Where(x => x.OaId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}