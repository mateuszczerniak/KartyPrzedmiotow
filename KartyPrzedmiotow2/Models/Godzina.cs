using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class Godzina
    {
        public int Stacjonarne { get; set; }
        public int Niestacjonarne { get; set; }
        public int TypLiczbGodzinId { get; set; }
        public string Nazwa { get; set; }
    }
}