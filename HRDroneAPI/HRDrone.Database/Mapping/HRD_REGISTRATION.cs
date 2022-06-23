using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
    public class HRD_REGISTRATION : IEntityTypeConfiguration<HrdRegistration>
    {
        public void Configure(EntityTypeBuilder<HrdRegistration> builder)
        {
            builder.ToTable("HRD_REGISTRATION");
            builder.HasKey(e => new { e.RegId });
            builder.Property(e => e.RegId).HasColumnName("REG_ID").IsRequired();
            builder.Property(e => e.DroneUid).HasColumnName("DRONE_UID");
            builder.Property(e => e.DroneName).HasColumnName("DRONE_NAME");
            builder.Property(e => e.CreatedOn).HasColumnName("CREATED_ON");

        }
    };
}
