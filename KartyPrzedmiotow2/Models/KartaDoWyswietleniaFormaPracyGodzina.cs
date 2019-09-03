using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaDoWyswietleniaFormaPracyGodzina
    {
        public int Godzin { get; internal set; }
        public string Nazwa { get; internal set; }
        public int TypLiczbaGodzinId { get; internal set; }
    }
}