using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_MOTOR : IEntityTypeConfiguration<HrdMotor>
    {
        public void Configure(EntityTypeBuilder<HrdMotor> builder)
        {
            builder.ToTable("HRD_MOTOR");
            builder.HasKey(e => new { e.MotorId });
            builder.Property(e => e.MotorId).HasColumnName("MOTOR_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.Speed).HasColumnName("Speed");
            builder.Property(e => e.EscTemp).HasColumnName("EscTemp");
            builder.Property(e => e.PPMrecv).HasColumnName("PPMrecv");
            builder.Property(e => e.V_out).HasColumnName("V_out");
            builder.Property(e => e.Volts).HasColumnName("Volts");
            builder.Property(e => e.MotorCurrent).HasColumnName("MotorCurrent");
            builder.Property(e => e.MotorStatus).HasColumnName("MotorStatus");
            builder.Property(e => e.PPMsend).HasColumnName("PPMsend");
            builder.Property(e => e.thrustAngle).HasColumnName("thrustAngle");

        }
    };
}