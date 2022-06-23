using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_AIRCRAFTCONDITION : IEntityTypeConfiguration<HrdAircraftcondition>
    {
        public void Configure(EntityTypeBuilder<HrdAircraftcondition> builder)
        {
            builder.ToTable("HRD_AIRCRAFTCONDITION");
            builder.HasKey(e => new { e.AirCraftConditionID });
            builder.Property(e => e.AirCraftConditionID).HasColumnName("AirCraftCondition_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.int_fsm).HasColumnName("int_fsm");
            builder.Property(e => e.last_fsm).HasColumnName("last_fsm");
            builder.Property(e => e.safe_fltr).HasColumnName("safe_fltr");
            builder.Property(e => e.launch_acc_dur).HasColumnName("launch_acc_dur");
            builder.Property(e => e.launch_free_fall_dur).HasColumnName("launch_free_fall_dur");
            builder.Property(e => e.launch_free_fall_delta_v).HasColumnName("launch_free_fall_delta_v");
            builder.Property(e => e.thrust).HasColumnName("thrust");
            builder.Property(e => e.gyro).HasColumnName("gyro");
            builder.Property(e => e.land_dur_press).HasColumnName("land_dur_press");
            builder.Property(e => e.land_dur_sonic).HasColumnName("land_dur_sonic");
            builder.Property(e => e.thrust_body).HasColumnName("thrust_body");
            builder.Property(e => e.thrust_gnd).HasColumnName("thrust_gnd");
            builder.Property(e => e.thrust_gnd_compen).HasColumnName("thrust_gnd_compen");
            builder.Property(e => e.safe_tilt_raw).HasColumnName("safe_tilt_raw");
            builder.Property(e => e.sat_timer).HasColumnName("sat_timer");
            builder.Property(e => e.fsmState).HasColumnName("fsmState");
            builder.Property(e => e.landState).HasColumnName("landState");
            builder.Property(e => e.UP_acc_t).HasColumnName("UP_acc_t");
            builder.Property(e => e.UP_TF_t).HasColumnName("UP_TF_t");
            builder.Property(e => e.craft_flight_mode).HasColumnName("craft_flight_mode");
            builder.Property(e => e.launch_acc_duration).HasColumnName("launch_acc_duration");
            builder.Property(e => e.launch_delta_v).HasColumnName("launch_delta_v");
            builder.Property(e => e.launch_state).HasColumnName("launch_state");
            builder.Property(e => e.thrust_proj_gnd).HasColumnName("thrust_proj_gnd");
            builder.Property(e => e.thrust_proj_gnd_compen).HasColumnName("thrust_proj_gnd_compen");
            builder.Property(e => e.thrust_compensator).HasColumnName("thrust_compensator");
            builder.Property(e => e.hover_thrust).HasColumnName("hover_thrust");
            builder.Property(e => e.dynamic_thrust).HasColumnName("dynamic_thrust");
            builder.Property(e => e.cos_safe_tilt).HasColumnName("cos_safe_tilt");
            builder.Property(e => e.safe_tilt).HasColumnName("safe_tilt");
            builder.Property(e => e.nearGround).HasColumnName("nearGround");
            builder.Property(e => e.gyro_acc).HasColumnName("gyro_acc");
            builder.Property(e => e.land_dur).HasColumnName("land_dur");

        }
    };
}