using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DecreaseCommute.MvcClient.Models
{
    public partial class DCdbContext : DbContext
    {
        public DCdbContext()
        {
        }

        public DCdbContext(DbContextOptions<DCdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TravelPlan> TravelPlan { get; set; }
        public virtual DbSet<TravelUser> TravelUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:cheesycheshire.database.windows.net,1433;Initial Catalog=DecreaseCommute;Persist Security Info=False;User ID=;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TravelPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("TravelPlan", "DCTravel");

                entity.Property(e => e.PlanId)
                    .HasColumnName("PlanID")
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.DestinationStation)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.SourceStation)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.UserName).HasMaxLength(1);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.TravelPlan)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK__TravelPla__UserN__4BAC3F29");
            });

            modelBuilder.Entity<TravelUser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("TravelUser", "DCTravel");

                entity.Property(e => e.UserName)
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasComputedColumnSql("(sysutcdatetime())");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1);
            });
        }
    }
}
