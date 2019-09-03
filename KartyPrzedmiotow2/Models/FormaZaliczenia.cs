using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KartyPrzedmiotow2.Models
{
    public class FormaZaliczenia
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Program> Programy { get; set; }
    }
}