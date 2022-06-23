using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_IMUEX : IEntityTypeConfiguration<HrdImuex>
    {
        public void Configure(EntityTypeBuilder<HrdImuex> builder)
        {
            builder.ToTable("HRD_IMUEX");
            builder.HasKey(e => new { e.ImuexId });
            builder.Property(e => e.ImuexId).HasColumnName("IMUEX_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.vo_v).HasColumnName("vo_v");
            builder.Property(e => e.vo_p).HasColumnName("vo_p");
            builder.Property(e => e.us_v).HasColumnName("us_v");
            builder.Property(e => e.us_p).HasColumnName("us_p");
            builder.Property(e => e.vo_flag_Navi).HasColumnName("vo_flag_Navi");
            builder.Property(e => e.cnt).HasColumnName("cnt");
            builder.Property(e => e.rtk_Longitude).HasColumnName("rtk_Longitude");
            builder.Property(e => e.rtk_Latitude).HasColumnName("rtk_Latitude");
            builder.Property(e => e.rtk_Alti).HasColumnName("rtk_Alti");
            builder.Property(e => e.err).HasColumnName("err");

        }
    };
}

