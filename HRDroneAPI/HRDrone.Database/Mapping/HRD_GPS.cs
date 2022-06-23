using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_GPS : IEntityTypeConfiguration<HrdGps>
    {
        public void Configure(EntityTypeBuilder<HrdGps> builder)
        {
            builder.ToTable("HRD_GPS");
            builder.HasKey(e => new { e.GpsId });
            builder.Property(e => e.GpsId).HasColumnName("GPS_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Long).HasColumnName("Long");
            builder.Property(e => e.Lat).HasColumnName("Lat");
            builder.Property(e => e.Date).HasColumnName("Date");
            builder.Property(e => e.Time).HasColumnName("Time");
            builder.Property(e => e.dateTime).HasColumnName("dateTime");
            builder.Property(e => e.heightMSL).HasColumnName("heightMSL");
            builder.Property(e => e.hDOP).HasColumnName("hDOP");
            builder.Property(e => e.pDOP).HasColumnName("pDOP");
            builder.Property(e => e.sAcc).HasColumnName("sAcc");
            builder.Property(e => e.numGPS).HasColumnName("numGPS");
            builder.Property(e => e.numGLNAS).HasColumnName("numGLNAS");
            builder.Property(e => e.numSV).HasColumnName("numSV");
            builder.Property(e => e.velNorthEastDown).HasColumnName("velNorthEastDown");

        }
    };
}
