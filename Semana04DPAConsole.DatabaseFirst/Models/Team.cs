using System;
using System.Collections.Generic;

namespace Semana04DPAConsole.DatabaseFirst.Models
{
    public partial class Team
    {
        public Team()
        {
            Player = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Country { get; set; } = null!;

        public virtual ICollection<Player> Player { get; set; }
    }
}
