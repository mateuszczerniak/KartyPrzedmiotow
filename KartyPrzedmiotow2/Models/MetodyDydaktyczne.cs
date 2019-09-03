using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class MetodyDydaktyczne
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<ProgramMetodyDydaktyczne> Programy { get; set; }

        [ForeignKey("GrupyMetodDydaktycznych")]
        public int GrupyMetodDydaktycznychId { get; set; }
        public virtual GrupyMetodDydaktycznych GrupyMetodDydaktycznych { get; set; }
    }
}