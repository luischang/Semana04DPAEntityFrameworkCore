using System;
using System.Collections.Generic;

namespace Semana04DPAConsole.DatabaseFirst.Models
{
    public partial class Player
    {
        public Player()
        {
            Team = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Dorsal { get; set; }

        public virtual ICollection<Team> Team { get; set; }
    }
}
