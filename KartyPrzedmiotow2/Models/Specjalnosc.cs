using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class Specjalnosc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }

        public virtual ICollection<Program> Programy { get; set; }

        [ForeignKey("Kierunek")]
        public int? KierunekId { get; set; }
        public Kierunek Kierunek { get; set; }
    }
}