using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana04DPAConsole.CodeFirst.Models
{
    public class FPFDbContext: DbContext
    {
        //OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            //Auth with user sql
            //var cnx = @"Server=.\SQLEXPRESS;Database=FPF;User Id=sa;Password=123;";            
            var cnx = @"Server=DESKTOP-S1DROK0\SQLEXPRESS;Database=FPFDb;Trusted_Connection=True;";           
            optionsBuilder.UseSqlServer(cnx).LogTo(Console.WriteLine, LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating to PlayerTeam with foreign key        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerTeam>()
              .HasKey(pt => new { pt.PlayerId, pt.TeamId });
            base.OnModelCreating(modelBuilder);
        }


        
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }

    }
}
