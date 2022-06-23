using HRDrone.Database.Mapping;
using HRDrone.Entity;
using HRDrone.Operational.Configs;
using Microsoft.EntityFrameworkCore;

namespace HRDrone.Database
{
 public class HrdContext : DbContext
    {
        public DbSet<HrdGeneral>? HrdGeneral { get; set; }
        public DbSet<HrdAircomp>? HrdAircomp { get; set; }
        public DbSet<HrdAircraftcondition>? HrdAircraftcondition { get; set; }
        public DbSet<HrdBattery>? HrdBattery { get; set; }
        public DbSet<HrdController>? HrdController { get; set; }
        public DbSet<HrdGps>? HrdGps { get; set; }
        public DbSet<HrdHp>? HrdHp { get; set; }
        public DbSet<HrdImuatti>? HrdImuatti { get; set; }
        public DbSet<HrdImuex>? HrdImuex { get; set; }
        public DbSet<HrdInertialonlycalcs>? HrdInertialonlycalcs { get; set; }
        public DbSet<HrdMag>? HrdMag { get; set; }
        public DbSet<HrdMotor>? HrdMotor { get; set; }
        public DbSet<HrdMotorctrl>? HrdMotorctrl { get; set; }
        public DbSet<HrdMotorpwrcalcs>? HrdMotorpwrcalcs { get; set; }
        public DbSet<HrdMvo>? HrdMvo { get; set; }
        public DbSet<HrdOa>? HrdOa { get; set; }
        public DbSet<HrdRc>? HrdRc { get; set; }
        public DbSet<HrdRegistration>? HrdRegistration { get; set; }
        public DbSet<HrdSmartBatt>? HrdSmartBatt { get; set; }
        public DbSet<HrdTracking>? HrdTracking { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(HRDConfig.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HRD_GENERAL());
            modelBuilder.ApplyConfiguration(new HRD_AIRCOMP());
            modelBuilder.ApplyConfiguration(new HRD_AIRCRAFTCONDITION());
            modelBuilder.ApplyConfiguration(new HRD_BATTERY());
            modelBuilder.ApplyConfiguration(new HRD_CONTROLLER());
            modelBuilder.ApplyConfiguration(new HRD_GPS());
            modelBuilder.ApplyConfiguration(new HRD_HP());
            modelBuilder.ApplyConfiguration(new HRD_IMUATTI());
            modelBuilder.ApplyConfiguration(new HRD_IMUEX());
            modelBuilder.ApplyConfiguration(new HRD_INERTIALONLYCALCS());
            modelBuilder.ApplyConfiguration(new HRD_MAG());
            modelBuilder.ApplyConfiguration(new HRD_MOTOR());
            modelBuilder.ApplyConfiguration(new HRD_MOTORCTRL());
            modelBuilder.ApplyConfiguration(new HRD_MOTORPWRCALCS());
            modelBuilder.ApplyConfiguration(new HRD_MVO());
            modelBuilder.ApplyConfiguration(new HRD_OA());
            modelBuilder.ApplyConfiguration(new HRD_RC());
            modelBuilder.ApplyConfiguration(new HRD_REGISTRATION());
            modelBuilder.ApplyConfiguration(new HRD_SMART_BATT());
            modelBuilder.ApplyConfiguration(new HRD_TRACKING());
        }
    }
}
