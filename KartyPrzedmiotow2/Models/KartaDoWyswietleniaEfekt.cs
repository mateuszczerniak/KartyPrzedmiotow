using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaDoWyswietleniaEfekt
    {
        public IEnumerable<string> Tresci { get; internal set; }
        public string Opis { get; internal set; }
        public IEnumerable<string> MetodyDydaktyczne { get; internal set; }
        public IEnumerable<string> MetodyOceniania { get; internal set; }
        public string PrzedmiotoweEfektyKsztalcenia { get; set; }
        public bool WymaganiaWstepne { get; set; }
    }
}