using HRDrone.Database;
using HRDrone.Entity;

namespace HRDrone.BusinessLogic
{
    public class HrdBatteryComponent
    {
        public HrdBattery Insert(HrdBattery item)
        {
            HrdBattery data = new HrdBattery();
            using (var context = new HrdContext())
            {
                data.TrackingId = item.TrackingId;
                data.lowVoltage = item.lowVoltage;
                data.status = item.status;
                data.cellVolts = item.cellVolts;
                data.batteryCurrent = item.batteryCurrent;
                data.totalVolts = item.totalVolts;
                data.Temp = item.Temp;
                data.batteryPercentage_FullChargeCap = item.batteryPercentage_FullChargeCap;
                data.batteryPercentage_RemainingCap = item.batteryPercentage_RemainingCap;
                data.batteryPercentage_voltSpread = item.batteryPercentage_voltSpread;
                data.watts_minCurrent = item.watts_minCurrent;
                data.watts_maxCurrent = item.watts_maxCurrent;
                data.watts_avgCurrent = item.watts_avgCurrent;
                data.watts_minVolts = item.watts_minVolts;
                data.watts_maxVolts = item.watts_maxVolts;
                data.watts_avgVolts = item.watts_avgVolts;
                data.watts_minWatts = item.watts_minWatts;
                data.watts_maxWatts = item.watts_maxWatts;
                data.watts_avgWatts = item.watts_avgWatts;
                context.HrdBattery!.Add(data);
                context.SaveChanges();
            }
            return data;
        }

        public void Update(HrdBattery item)
        {
            using (var context = new HrdContext())
            {
                var data = context.HrdBattery!.Where(x => x.BatteryId == item.BatteryId).FirstOrDefault();
                if (data != null)
                {
                    data.TrackingId = item.TrackingId;
                    data.lowVoltage = item.lowVoltage;
                    data.status = item.status;
                    data.cellVolts = item.cellVolts;
                    data.batteryCurrent = item.batteryCurrent;
                    data.totalVolts = item.totalVolts;
                    data.Temp = item.Temp;
                    data.batteryPercentage_FullChargeCap = item.batteryPercentage_FullChargeCap;
                    data.batteryPercentage_RemainingCap = item.batteryPercentage_RemainingCap;
                    data.batteryPercentage_voltSpread = item.batteryPercentage_voltSpread;
                    data.watts_minCurrent = item.watts_minCurrent;
                    data.watts_maxCurrent = item.watts_maxCurrent;
                    data.watts_avgCurrent = item.watts_avgCurrent;
                    data.watts_minVolts = item.watts_minVolts;
                    data.watts_maxVolts = item.watts_maxVolts;
                    data.watts_avgVolts = item.watts_avgVolts;
                    data.watts_minWatts = item.watts_minWatts;
                    data.watts_maxWatts = item.watts_maxWatts;
                    data.watts_avgWatts = item.watts_avgWatts;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int Id)
        {
            using (var context = new HrdContext())
            {
                var obj = new HrdBattery { BatteryId = Id };
                context.Remove(obj);
                context.SaveChanges();
            }
        }


        public HrdBattery GetDataById(int? Id)
        {
            HrdBattery obj = null;
            using (var context = new HrdContext())
            {
                obj = context.HrdBattery!.Where(x => x.BatteryId == Id).FirstOrDefault()!;
            }
            return obj;
        }
    }

}
