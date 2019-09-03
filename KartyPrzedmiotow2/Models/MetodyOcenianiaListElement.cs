using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class MetodyOcenianiaListElement
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        [DisplayName("Liczba programów")]
        public int LiczbaProgramow { get; set; }
    }
}