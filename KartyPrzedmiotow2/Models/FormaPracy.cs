using System.ComponentModel.DataAnnotations;

namespace KartyPrzedmiotow2.Models
{
    public class FormaPracy
    {
        [Key]
        public int FormaPracyId { get; set; }
        public string Opis { get; set; }
    }
}