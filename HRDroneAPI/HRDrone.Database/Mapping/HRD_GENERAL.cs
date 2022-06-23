using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_GENERAL : IEntityTypeConfiguration<HrdGeneral>
    {
        public void Configure(EntityTypeBuilder<HrdGeneral> builder)
        {
            builder.ToTable("HRD_GENERAL");
            builder.HasKey(e => new { e.GeneralId });
            builder.Property(e => e.GeneralId).HasColumnName("GENERAL_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.relativeHeight).HasColumnName("relativeHeight");
            builder.Property(e => e.absoluteHeight).HasColumnName("absoluteHeight");
            builder.Property(e => e.flightTime).HasColumnName("flightTime");
            builder.Property(e => e.gpsHealth).HasColumnName("gpsHealth");
            builder.Property(e => e.vpsHeight).HasColumnName("vpsHeight");
            builder.Property(e => e.flyCState).HasColumnName("flyCState");
            builder.Property(e => e.flycCommand).HasColumnName("flycCommand");
            builder.Property(e => e.flightAction).HasColumnName("flightAction");
            builder.Property(e => e.nonGPSCause).HasColumnName("nonGPSCause");
            builder.Property(e => e.connectedToRC).HasColumnName("connectedToRC");
            builder.Property(e => e.gpsUsed).HasColumnName("gpsUsed");
            builder.Property(e => e.visionUsed).HasColumnName("visionUsed");
            builder.Property(e => e.CreatedOn).HasColumnName("CREATED_ON");
        }
    };
}
