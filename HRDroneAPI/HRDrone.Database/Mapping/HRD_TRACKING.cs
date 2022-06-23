using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_TRACKING : IEntityTypeConfiguration<HrdTracking>
    {
        public void Configure(EntityTypeBuilder<HrdTracking> builder)
        {
            builder.ToTable("HRD_TRACKING");
            builder.HasKey(e => new { e.TrackingId });
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.RegId).HasColumnName("REG_ID");
            builder.Property(e => e.StartDatetime).HasColumnName("START_DATETIME");
            builder.Property(e => e.EndDatetime).HasColumnName("END_DATETIME");
            builder.Property(e => e.Height).HasColumnName("HEIGHT");
            builder.Property(e => e.BatterLv).HasColumnName("BATTERY_LV");
            builder.Property(e => e.Speed).HasColumnName("SPEED");
            builder.Property(e => e.Latitude).HasColumnName("LATITUDE");
            builder.Property(e => e.Longittude).HasColumnName("LONGITTUDE");

        }
    };
}
