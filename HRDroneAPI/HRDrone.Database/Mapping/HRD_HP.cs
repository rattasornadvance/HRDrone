using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_HP : IEntityTypeConfiguration<HrdHp>
    {
        public void Configure(EntityTypeBuilder<HrdHp> builder)
        {
            builder.ToTable("HRD_HP");
            builder.HasKey(e => new { e.HpId });
            builder.Property(e => e.HpId).HasColumnName("HP_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Longitude).HasColumnName("Longitude");
            builder.Property(e => e.Latitude).HasColumnName("Latitude");
            builder.Property(e => e.Altitude).HasColumnName("Altitude");
            builder.Property(e => e.rthHeight).HasColumnName("rthHeight");
        }
    };
}
