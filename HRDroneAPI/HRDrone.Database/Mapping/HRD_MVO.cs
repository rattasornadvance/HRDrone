using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_MVO : IEntityTypeConfiguration<HrdMvo>
    {
        public void Configure(EntityTypeBuilder<HrdMvo> builder)
        {
            builder.ToTable("HRD_MVO");
            builder.HasKey(e => new { e.MovId });
            builder.Property(e => e.MovId).HasColumnName("MOV_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.vel).HasColumnName("vel");
            builder.Property(e => e.pos).HasColumnName("pos");
            builder.Property(e => e.hoverPointUncertainty1).HasColumnName("hoverPointUncertainty1");
            builder.Property(e => e.hoverPointUncertainty2).HasColumnName("hoverPointUncertainty2");
            builder.Property(e => e.hoverPointUncertainty3).HasColumnName("hoverPointUncertainty3");
            builder.Property(e => e.hoverPointUncertainty4).HasColumnName("hoverPointUncertainty4");
            builder.Property(e => e.hoverPointUncertainty5).HasColumnName("hoverPointUncertainty5");
            builder.Property(e => e.hoverPointUncertainty6).HasColumnName("hoverPointUncertainty6");
            builder.Property(e => e.velocityUncertainty1).HasColumnName("velocityUncertainty1");
            builder.Property(e => e.velocityUncertainty2).HasColumnName("velocityUncertainty2");
            builder.Property(e => e.velocityUncertainty3).HasColumnName("velocityUncertainty3");
            builder.Property(e => e.velocityUncertainty4).HasColumnName("velocityUncertainty4");
            builder.Property(e => e.velocityUncertainty5).HasColumnName("velocityUncertainty5");
            builder.Property(e => e.velocityUncertainty6).HasColumnName("velocityUncertainty6");
            builder.Property(e => e.height).HasColumnName("height");
            builder.Property(e => e.heightUncertainty).HasColumnName("heightUncertainty");

        }
    };
}
