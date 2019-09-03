using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaFormaPracy
    {
        public KartaFormaPracy()
        {
            Dzienne = new List<KartaFormaPracyGodzina>();
            Zaoczne = new List<KartaFormaPracyGodzina>();
        }

        public int FormaPracyId { get; set; }
        public string Opis { get; set; }

        public List<KartaFormaPracyGodzina> Dzienne { get; set; }
        public List<KartaFormaPracyGodzina> Zaoczne { get; set; }
    }
}