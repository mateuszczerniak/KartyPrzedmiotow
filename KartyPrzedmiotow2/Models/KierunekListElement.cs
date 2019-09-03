using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KierunekListElement
    {
        public int Id { get; internal set; }
        public string Nazwa { get; internal set; }
        [DisplayName("Liczba programów")]
        public int LiczbaProgramow { get; internal set; }
        [DisplayName("Liczba specjalności")]
        public int LiczbaSpecjalnosci { get; internal set; }
    }
}