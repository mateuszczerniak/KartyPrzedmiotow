using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class Kierunek
    {
        public Kierunek()
        {
            Program = new List<Program>();
            Specjalnosci = new List<Specjalnosc>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }

        public ICollection<Program> Program { get; set; }
        public ICollection<Specjalnosc> Specjalnosci { get; set; }

        [ForeignKey("Wydzial")]
        public int? WydzialId { get; set; }
        public Wydzial Wydzial { get; set; }
    }
}