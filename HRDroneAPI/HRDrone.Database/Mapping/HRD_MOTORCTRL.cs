using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_MOTORCTRL : IEntityTypeConfiguration<HrdMotorctrl>
    {
        public void Configure(EntityTypeBuilder<HrdMotorctrl> builder)
        {
            builder.ToTable("HRD_MOTORCTRL");
            builder.HasKey(e => new { e.MotorctrlId });
            builder.Property(e => e.MotorctrlId).HasColumnName("MOTORCTRL_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.MotorCtrlStatus).HasColumnName("MotorCtrlStatus");
            builder.Property(e => e.PWM).HasColumnName("PWM");
        }
    };
}
