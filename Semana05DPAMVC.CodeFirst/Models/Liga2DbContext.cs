using Microsoft.EntityFrameworkCore;

namespace Semana05DPAMVC.CodeFirst.Models
{
    public class Liga2DbContext : DbContext
    {
        //Add Constructor
        public Liga2DbContext(DbContextOptions<Liga2DbContext> options)
            : base(options)
        { 
        
        }

        //Add DbSets
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }


    }
}
