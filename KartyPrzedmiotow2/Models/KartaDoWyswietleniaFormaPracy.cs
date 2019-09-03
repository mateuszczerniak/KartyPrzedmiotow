using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaDoWyswietleniaFormaPracy
    {
        public string Nazwa { get; internal set; }
        public List<KartaDoWyswietleniaFormaPracyGodzina> Godziny { get; internal set; }
    }
}