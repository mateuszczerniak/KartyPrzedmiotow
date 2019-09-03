using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaGodzina
    {
        public KartaGodzina()
        {
            Tresci = new List<KartaGodzinaTresci>();
        }
        public int TypLiczbaGodzinId { get; set; }
        public string Nazwa { get; set; }
        public IList<KartaGodzinaTresci> Tresci { get; set; }
        public int Stacjonarne { get; set; }
        public int Niestacjonarne { get; set; }
    }
}