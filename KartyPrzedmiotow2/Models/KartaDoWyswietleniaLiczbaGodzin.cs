using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaDoWyswietleniaLiczbaGodzin
    {
        public int Stacjonarne { get; set; }
        public int Niestacjonarne { get; set; }
        public int TypLiczbaGodzinId { get; set; }
        public string Typ { get; internal set; }
    }
}