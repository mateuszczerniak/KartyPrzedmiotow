using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class Tresci
    {
        [Key]
        public int Id { get; set; }
        public string Opis { get; set; }
        public int Skrot { get; set; }


        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
        [ForeignKey("TypLiczbaGodzin")]
        public int TypLiczbaGodzinId { get; set; }
        public virtual TypLiczbaGodzin TypLiczbaGodzin { get; set; }
    }
}