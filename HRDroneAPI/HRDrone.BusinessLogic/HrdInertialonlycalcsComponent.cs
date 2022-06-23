using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdInertialonlycalcsComponent
    {
        public HrdInertialonlycalcs Insert(HrdInertialonlycalcs item)
        {
            HrdInertialonlycalcs data = new HrdInertialonlycalcs();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.VelNorthEastDown = item.VelNorthEastDown;
                data.PoslNorthEastDown = item.PoslNorthEastDown;
                data.agNorthEastDown = item.agNorthEastDown;
                data.abNorthEastDown = item.abNorthEastDown;
                data.VeIN_vgX = item.VeIN_vgX;
                data.VE_vgY = item.VE_vgY;
                data.Vd_vgZ = item.Vd_vgZ;

                context.HrdInertialonlycalcs!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdInertialonlycalcs item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdInertialonlycalcs!.Where(x => x.InertialonlycalcsId == item.InertialonlycalcsId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.VelNorthEastDown = item.VelNorthEastDown;
                    data.PoslNorthEastDown = item.PoslNorthEastDown;
                    data.agNorthEastDown = item.agNorthEastDown;
                    data.abNorthEastDown = item.abNorthEastDown;
                    data.VeIN_vgX = item.VeIN_vgX;
                    data.VE_vgY = item.VE_vgY;
                    data.Vd_vgZ = item.Vd_vgZ;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdInertialonlycalcs { InertialonlycalcsId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdInertialonlycalcs GetDataById(int? Id)
        {
            HrdInertialonlycalcs obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdInertialonlycalcs!.Where(x => x.InertialonlycalcsId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
