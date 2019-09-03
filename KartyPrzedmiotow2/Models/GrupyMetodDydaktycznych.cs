using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Models
{
    public class GrupyMetodDydaktycznych
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<MetodyDydaktyczne> MetodyDydaktyczne { get; set; }
    }
}