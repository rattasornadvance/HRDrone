using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdMvoComponent
    {
        public HrdMvo Insert(HrdMvo item)
        {
            HrdMvo data = new HrdMvo();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.vel = item.vel;
                data.pos = item.pos;
                data.hoverPointUncertainty1 = item.hoverPointUncertainty1;
                data.hoverPointUncertainty2 = item.hoverPointUncertainty2;
                data.hoverPointUncertainty3 = item.hoverPointUncertainty3;
                data.hoverPointUncertainty4 = item.hoverPointUncertainty4;
                data.hoverPointUncertainty5 = item.hoverPointUncertainty5;
                data.hoverPointUncertainty6 = item.hoverPointUncertainty6;
                data.velocityUncertainty1 = item.velocityUncertainty1;
                data.velocityUncertainty2 = item.velocityUncertainty2;
                data.velocityUncertainty3 = item.velocityUncertainty3;
                data.velocityUncertainty4 = item.velocityUncertainty4;
                data.velocityUncertainty5 = item.velocityUncertainty5;
                data.velocityUncertainty6 = item.velocityUncertainty6;
                data.height = item.height;
                data.heightUncertainty = item.heightUncertainty;

                context.HrdMvo!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdMvo item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdMvo!.Where(x => x.MovId == item.MovId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.vel = item.vel;
                    data.pos = item.pos;
                    data.hoverPointUncertainty1 = item.hoverPointUncertainty1;
                    data.hoverPointUncertainty2 = item.hoverPointUncertainty2;
                    data.hoverPointUncertainty3 = item.hoverPointUncertainty3;
                    data.hoverPointUncertainty4 = item.hoverPointUncertainty4;
                    data.hoverPointUncertainty5 = item.hoverPointUncertainty5;
                    data.hoverPointUncertainty6 = item.hoverPointUncertainty6;
                    data.velocityUncertainty1 = item.velocityUncertainty1;
                    data.velocityUncertainty2 = item.velocityUncertainty2;
                    data.velocityUncertainty3 = item.velocityUncertainty3;
                    data.velocityUncertainty4 = item.velocityUncertainty4;
                    data.velocityUncertainty5 = item.velocityUncertainty5;
                    data.velocityUncertainty6 = item.velocityUncertainty6;
                    data.height = item.height;
                    data.heightUncertainty = item.heightUncertainty;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdMvo { MovId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdMvo GetDataById(int? Id)
        {
            HrdMvo obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdMvo!.Where(x => x.MovId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}

