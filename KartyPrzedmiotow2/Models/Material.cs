using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KartyPrzedmiotow2.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Wykladowca { get; set; }

        public virtual ICollection<PrzedmiotOpis> PrzedmiotOpisy { get; set; }
    }
}