using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_RC : IEntityTypeConfiguration<HrdRc>
    {
        public void Configure(EntityTypeBuilder<HrdRc> builder)
        {
            builder.ToTable("HRD_RC");
            builder.HasKey(e => new { e.RcId });
            builder.Property(e => e.RcId).HasColumnName("RC_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Aileron).HasColumnName("Aileron");
            builder.Property(e => e.Elevator).HasColumnName("Elevator");
            builder.Property(e => e.Rudder).HasColumnName("Rudder");
            builder.Property(e => e.Throttle).HasColumnName("Throttle");
            builder.Property(e => e.ModeSwitch).HasColumnName("ModeSwitch");
            builder.Property(e => e.sigStrength).HasColumnName("sigStrength");
            builder.Property(e => e.failSafe).HasColumnName("failSafe");
            builder.Property(e => e.dataLost).HasColumnName("dataLost");
            builder.Property(e => e.appLost).HasColumnName("appLost");
            builder.Property(e => e.connected).HasColumnName("connected");
        }
    };
}

