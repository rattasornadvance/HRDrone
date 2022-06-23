using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_MAG : IEntityTypeConfiguration<HrdMag>
    {
        public void Configure(EntityTypeBuilder<HrdMag> builder)
        {
            builder.ToTable("HRD_MAG");
            builder.HasKey(e => new { e.MagId });
            builder.Property(e => e.MagId).HasColumnName("MAG_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Mod).HasColumnName("Mod");
            builder.Property(e => e.magYaw).HasColumnName("magYaw");
            builder.Property(e => e.Yaw_magYaw).HasColumnName("Yaw_magYaw");
            builder.Property(e => e.raw).HasColumnName("raw");
            builder.Property(e => e.rawMod).HasColumnName("rawMod");
        }
    };
}
