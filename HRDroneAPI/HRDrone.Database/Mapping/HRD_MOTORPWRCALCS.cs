using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_MOTORPWRCALCS : IEntityTypeConfiguration<HrdMotorpwrcalcs>
    {
        public void Configure(EntityTypeBuilder<HrdMotorpwrcalcs> builder)
        {
            builder.ToTable("HRD_MOTORPWRCALCS");
            builder.HasKey(e => new { e.MotorpwrcalcsId });
            builder.Property(e => e.MotorpwrcalcsId).HasColumnName("MOTORPWRCALCS_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.VoltsAvg).HasColumnName("VoltsAvg");
            builder.Property(e => e.VoltsAvgAll).HasColumnName("VoltsAvgAll");
            builder.Property(e => e.CurrentAvg).HasColumnName("CurrentAvg");
            builder.Property(e => e.CurrentAvgAll).HasColumnName("CurrentAvgAll");
            builder.Property(e => e.WattsAvg).HasColumnName("WattsAvg");
            builder.Property(e => e.WattsAvgAll).HasColumnName("WattsAvgAll");
            builder.Property(e => e.WattSecs).HasColumnName("WattSecs");
            builder.Property(e => e.WattSecsAll).HasColumnName("WattSecsAll");
            builder.Property(e => e.WattSecsDist).HasColumnName("WattSecsDist");
            builder.Property(e => e.WattSecsDistAll).HasColumnName("WattSecsDistAll");
            builder.Property(e => e.WattSecsTotalDist).HasColumnName("WattSecsTotalDist");
            builder.Property(e => e.WattSecsTotalDistAll).HasColumnName("WattSecsTotalDistAll");
            builder.Property(e => e.WattsVelH).HasColumnName("WattsVelH");
            builder.Property(e => e.WattsVelHAll).HasColumnName("WattsVelHAll");
            builder.Property(e => e.WattsVelD).HasColumnName("WattsVelD");
            builder.Property(e => e.WattsVelDAll).HasColumnName("WattsVelDAll");
        }
    };
}
