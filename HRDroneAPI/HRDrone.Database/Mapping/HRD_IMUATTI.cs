using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_IMUATTI : IEntityTypeConfiguration<HrdImuatti>
    {
        public void Configure(EntityTypeBuilder<HrdImuatti> builder)
        {
            builder.ToTable("HRD_IMUATTI");
            builder.HasKey(e => new { e.ImuId });
            builder.Property(e => e.ImuId).HasColumnName("IMU_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Longitude).HasColumnName("Longitude");
            builder.Property(e => e.Latitude).HasColumnName("Latitude");
            builder.Property(e => e.barometerRaw).HasColumnName("barometerRaw");
            builder.Property(e => e.barometerSmooth).HasColumnName("barometerSmooth");
            builder.Property(e => e.accelAxis).HasColumnName("accelAxis");
            builder.Property(e => e.accelComposite).HasColumnName("accelComposite");
            builder.Property(e => e.gyroAxis).HasColumnName("gyroAxis");
            builder.Property(e => e.gyroComposite).HasColumnName("gyroComposite");
            builder.Property(e => e.magAxis).HasColumnName("magAxis");
            builder.Property(e => e.magMod).HasColumnName("magMod");
            builder.Property(e => e.VelNorthEastDown).HasColumnName("VelNorthEastDown");
            builder.Property(e => e.velComposite).HasColumnName("velComposite");
            builder.Property(e => e.velH).HasColumnName("velH");
            builder.Property(e => e.GPS_H).HasColumnName("GPS_H");
            builder.Property(e => e.quatWXYZ).HasColumnName("quatWXYZ");
            builder.Property(e => e.roll).HasColumnName("roll");
            builder.Property(e => e.pitch).HasColumnName("pitch");
            builder.Property(e => e.yaw).HasColumnName("yaw");
            builder.Property(e => e.yaw360).HasColumnName("yaw360");
            builder.Property(e => e.totalGyroAxis).HasColumnName("totalGyroAxis");
            builder.Property(e => e.magYaw).HasColumnName("magYaw");
            builder.Property(e => e.Yaw_magYaw).HasColumnName("Yaw_magYaw");
            builder.Property(e => e.distanceHP).HasColumnName("distanceHP");
            builder.Property(e => e.distanceTravelled).HasColumnName("distanceTravelled");
            builder.Property(e => e.directionOfTravelMag).HasColumnName("directionOfTravelMag");
            builder.Property(e => e.directionOfTravelTrue).HasColumnName("directionOfTravelTrue");
            builder.Property(e => e.temperature).HasColumnName("temperature");
            builder.Property(e => e.ag_Axis).HasColumnName("ag_Axis");
            builder.Property(e => e.gb_Axis).HasColumnName("gb_Axis");
        }
    };
}

