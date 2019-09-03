using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KartyPrzedmiotow2.Models
{
    public class Tytul
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Kolejnosc { get; set; }

        public virtual ICollection<Uzytkownik> Wykladowcy { get; set; }

    }
}