using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaEfektGodzina
    {
        public KartaEfektGodzina()
        {
            WybraneTresci = new List<int>();
        }



        public int TypLiczbaGodzinId { get; set; }
        public string Nazwa { get; set; }

        public List<int> WybraneTresci { get; set; }
    }
}