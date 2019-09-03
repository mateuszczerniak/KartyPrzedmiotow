using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class Efekt
    {
        [Key]
        public int Id { get; set; }
        public string Skrot { get; set; }
        public string Opis { get; set; }

        [ForeignKey("RodzajEfektu")]
        public int RodzajEfektuId { get; set; }
        public virtual RodzajEfektu RodzajEfektu { get; set; }

        [ForeignKey("Poziom")]
        public int PoziomId { get; set; }
        public virtual Poziom Poziom { get; set; }
        [ForeignKey("Wydzial")]
        public int WydzialId { get; set; }
        public virtual Wydzial Wydzial { get; set; }
    }
}