namespace StationLogWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StationLogModel : DbContext
    {
        public StationLogModel()
            : base("name=StationLogModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Instrument> Instruments { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instrument>()
                .Property(e => e.InstrumentName)
                .IsUnicode(false);

            modelBuilder.Entity<Instrument>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Instrument>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Instrument1)
                .HasForeignKey(e => e.Instrument)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Station>()
                .Property(e => e.StationName)
                .IsUnicode(false);

            modelBuilder.Entity<Station>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Station)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Instrument)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Schedule)
                .IsUnicode(false);
        }
    }
}
