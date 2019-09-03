using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class TypLiczbaGodzin
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<LiczbaGodzin> LiczbaGodzin { get; set; }
    }
}