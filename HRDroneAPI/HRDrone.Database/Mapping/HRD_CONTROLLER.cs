using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_CONTROLLER : IEntityTypeConfiguration<HrdController>
    {
        public void Configure(EntityTypeBuilder<HrdController> builder)
        {
            builder.ToTable("HRD_CONTROLLER");
            builder.HasKey(e => new { e.ControllerId });
            builder.Property(e => e.ControllerId).HasColumnName("CONTROLLER_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.gpsLevel).HasColumnName("gpsLevel");
            builder.Property(e => e.ctrl_level).HasColumnName("ctrl_level");
        }
    };
}
