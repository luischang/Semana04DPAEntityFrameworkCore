using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana05DPAMVC.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        public int Dorsal { get; set; }

        public Player()
        {

        }

        public Player(string fullName, int dorsal)
        {
            this.FullName = fullName;
            this.Dorsal = dorsal;
        }
    }
}
