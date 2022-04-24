using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Semana04DPAConsole.DatabaseFirst.Models
{
    public partial class FPFDbContext : DbContext
    {
        public FPFDbContext()
        {
        }

        public FPFDbContext(DbContextOptions<FPFDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; } = null!;
        public virtual DbSet<Team> Team { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=FPFDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.HasMany(d => d.Team)
                    .WithMany(p => p.Player)
                    .UsingEntity<Dictionary<string, object>>(
                        "PlayerTeam",
                        l => l.HasOne<Team>().WithMany().HasForeignKey("TeamId"),
                        r => r.HasOne<Player>().WithMany().HasForeignKey("PlayerId"),
                        j =>
                        {
                            j.HasKey("PlayerId", "TeamId");

                            j.ToTable("PlayerTeam");

                            j.HasIndex(new[] { "TeamId" }, "IX_PlayerTeam_TeamId");
                        });
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(80);

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
