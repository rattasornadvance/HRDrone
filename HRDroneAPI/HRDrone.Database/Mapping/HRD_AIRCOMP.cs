using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_AIRCOMP : IEntityTypeConfiguration<HrdAircomp>
    {
        public void Configure(EntityTypeBuilder<HrdAircomp> builder)
        {
            builder.ToTable("HRD_AIRCOMP");
            builder.HasKey(e => new { e.AircompId });
            builder.Property(e => e.AircompId).HasColumnName("AIRCOMP_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.AirSpeedBodyX).HasColumnName("AirSpeedBodyX");
            builder.Property(e => e.AirSpeedBodyY).HasColumnName("AirSpeedBodyY");
            builder.Property(e => e.Alti).HasColumnName("Alti");
            builder.Property(e => e.VelNorm).HasColumnName("VelNorm");
            builder.Property(e => e.VelTime1).HasColumnName("VelTime1");
            builder.Property(e => e.VelTime2).HasColumnName("VelTime2");
            builder.Property(e => e.VelLevel).HasColumnName("VelLevel");
            builder.Property(e => e.WindSpeed).HasColumnName("WindSpeed");
            builder.Property(e => e.WindX).HasColumnName("WindX");
            builder.Property(e => e.WindY).HasColumnName("WindY");
            builder.Property(e => e.MotorSpeed).HasColumnName("MotorSpeed");
            builder.Property(e => e.WindHeading).HasColumnName("WindHeading");
            builder.Property(e => e.WindMagnitude).HasColumnName("WindMagnitude");
            builder.Property(e => e.WindMagnitude2).HasColumnName("WindMagnitude2");
        }
    };
}