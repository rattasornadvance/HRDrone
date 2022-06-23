using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_OA : IEntityTypeConfiguration<HrdOa>
    {
        public void Configure(EntityTypeBuilder<HrdOa> builder)
        {
            builder.ToTable("HRD_OA");
            builder.HasKey(e => new { e.OaId });
            builder.Property(e => e.OaId).HasColumnName("OA_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.avoidObst).HasColumnName("avoidObst");
            builder.Property(e => e.emergBrake).HasColumnName("emergBrake");
            builder.Property(e => e.radiusLimit).HasColumnName("radiusLimit");
            builder.Property(e => e.airportLimit).HasColumnName("airportLimit");
            builder.Property(e => e.groundForceLanding).HasColumnName("groundForceLanding");
            builder.Property(e => e.horizNearBoundary).HasColumnName("horizNearBoundary");
            builder.Property(e => e.vertLowLimit).HasColumnName("vertLowLimit");
            builder.Property(e => e.vertAirportLimit).HasColumnName("vertAirportLimit");
            builder.Property(e => e.roofLimit).HasColumnName("roofLimit");
            builder.Property(e => e.hitGroundLimit).HasColumnName("hitGroundLimit");
            builder.Property(e => e.frontDistance).HasColumnName("frontDistance");
        }
    };
}

