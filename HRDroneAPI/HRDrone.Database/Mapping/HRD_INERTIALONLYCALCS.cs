using HRDrone.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRDrone.Database.Mapping
{
  public class HRD_INERTIALONLYCALCS : IEntityTypeConfiguration<HrdInertialonlycalcs>
    {
        public void Configure(EntityTypeBuilder<HrdInertialonlycalcs> builder)
        {
            builder.ToTable("HRD_INERTIALONLYCALCS");
            builder.HasKey(e => new { e.InertialonlycalcsId });
            builder.Property(e => e.InertialonlycalcsId).HasColumnName("INERTIALONLYCALCS_ID").IsRequired();
            builder.Property(e => e.TrackingId).HasColumnName("TRACKING_ID");
            builder.Property(e => e.VelNorthEastDown).HasColumnName("VelNorthEastDown");
            builder.Property(e => e.PoslNorthEastDown).HasColumnName("PoslNorthEastDown");
            builder.Property(e => e.agNorthEastDown).HasColumnName("agNorthEastDown");
            builder.Property(e => e.abNorthEastDown).HasColumnName("abNorthEastDown");
            builder.Property(e => e.VeIN_vgX).HasColumnName("VeIN_vgX");
            builder.Property(e => e.VE_vgY).HasColumnName("VE_vgY");
            builder.Property(e => e.Vd_vgZ).HasColumnName("Vd_vgZ");
        }
    };
}

