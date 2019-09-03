using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramFormaPracyGodzina
    {
        [Key]
        public int FormaPracyGodzinaId { get; set; }

        public int Godzin { get; set; }

        public bool Dzienna { get; set; }

        [ForeignKey("FormaPracy")]
        public int FormaPracyId { get; set; }
        public virtual FormaPracy FormaPracy { get; set; }

        [ForeignKey("LiczbaGodzin")]
        public int LiczbaGodzinId { get; set; }
        public virtual LiczbaGodzin LiczbaGodzin { get; set; }
    }
}