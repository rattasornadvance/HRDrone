using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_SMART_BATT : IEntityTypeConfiguration<HrdSmartBatt>
    {
        public void Configure(EntityTypeBuilder<HrdSmartBatt> builder)
        {
            builder.ToTable("HRD_SMART_BATT");
            builder.HasKey(e => new { e.SmartBattId });
            builder.Property(e => e.SmartBattId).HasColumnName("SMART_BATT_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.goHomePercentage).HasColumnName("goHomePercentage");
            builder.Property(e => e.landPercentage).HasColumnName("landPercentage");
            builder.Property(e => e.goHomeTime).HasColumnName("goHomeTime");
            builder.Property(e => e.landTime).HasColumnName("landTime");
            builder.Property(e => e.voltagePercentage).HasColumnName("voltagePercentage");
            builder.Property(e => e.smartBattStatus).HasColumnName("smartBattStatus");
            builder.Property(e => e.GHStatus).HasColumnName("GHStatus");

        }
    };
}
