using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_BATTERY : IEntityTypeConfiguration<HrdBattery>
    {
        public void Configure(EntityTypeBuilder<HrdBattery> builder)
        {
            builder.ToTable("HRD_BATTERY");
            builder.HasKey(e => new { e.BatteryId });
            builder.Property(e => e.BatteryId).HasColumnName("BATTERY_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.lowVoltage).HasColumnName("lowVoltage");
            builder.Property(e => e.status).HasColumnName("status");
            builder.Property(e => e.cellVolts).HasColumnName("cellVolts");
            builder.Property(e => e.batteryCurrent).HasColumnName("batteryCurrent");
            builder.Property(e => e.totalVolts).HasColumnName("totalVolts");
            builder.Property(e => e.Temp).HasColumnName("Temp");
            builder.Property(e => e.batteryPercentage_FullChargeCap).HasColumnName("batteryPercentage_FullChargeCap");
            builder.Property(e => e.batteryPercentage_RemainingCap).HasColumnName("batteryPercentage_RemainingCap");
            builder.Property(e => e.batteryPercentage_voltSpread).HasColumnName("batteryPercentage_voltSpread");
            builder.Property(e => e.watts_minCurrent).HasColumnName("watts_minCurrent");
            builder.Property(e => e.watts_maxCurrent).HasColumnName("watts_maxCurrent");
            builder.Property(e => e.watts_avgCurrent).HasColumnName("watts_avgCurrent");
            builder.Property(e => e.watts_minVolts).HasColumnName("watts_minVolts");
            builder.Property(e => e.watts_maxVolts).HasColumnName("watts_maxVolts");
            builder.Property(e => e.watts_avgVolts).HasColumnName("watts_avgVolts");
            builder.Property(e => e.watts_minWatts).HasColumnName("watts_minWatts");
            builder.Property(e => e.watts_maxWatts).HasColumnName("watts_maxWatts");
            builder.Property(e => e.watts_avgWatts).HasColumnName("watts_avgWatts");
        }
    };
}