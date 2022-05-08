using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana05DPAMVC.CodeFirst.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(80)")]
        public string Country { get; set; }

    }
}
