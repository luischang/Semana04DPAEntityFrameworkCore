using System;
using System.Collections.Generic;

namespace Semana05DPAMVC.DatabaseFirst.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
