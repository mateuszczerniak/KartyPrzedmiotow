using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class PrzedmiotOpis
    {
        public PrzedmiotOpis()
        {
            Literatury = new List<Literatura>();
        }

        [Key]
        public int Id { get; set; }
        public string NazwaAngielski { get; set; }
        public string Rok { get; set; }
        public string KrotkiOpis { get; set; }
        public string Wykladowca { get; set; }
        public string CelGlowny { get; set; }
        public string CelWiedza { get; set; }
        public string CelUmiejetnosci { get; set; }
        public string CelKompetencje { get; set; }

        [ForeignKey("Jezyki")]
        public int JezykiId { get; set; }
        public virtual Jezyk Jezyki { get; set; }
        [ForeignKey("Materialy")]
        public int MaterialyId { get; set; }
        public virtual Material Materialy { get; set; }
        public virtual ICollection<Literatura> Literatury { get; set; }
    }
}