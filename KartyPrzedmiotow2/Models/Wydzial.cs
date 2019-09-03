using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KartyPrzedmiotow2.Models
{
    public class Wydzial
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }

        public virtual ICollection<Program> Program { get; set; }
        public virtual ICollection<Efekt> Efekty { get; set; }
        public virtual ICollection<UzytkownikWydzialy> Uzytkownicy { get; set; }
        public virtual ICollection<Kierunek> Kierunki { get; set; }
    }
}