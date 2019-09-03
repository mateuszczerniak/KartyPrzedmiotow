using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class WydzialListElement
    {
        public int Id { get; internal set; }
        public string Nazwa { get; internal set; }
        [DisplayName("Liczba programów")]
        public int LiczbaProgramow { get; internal set; }
        [DisplayName("Liczba kierunków")]
        public int LiczbaKierunkow { get; internal set; }
        [DisplayName("Liczba użytkowników")]
        public int LiczbaUzytkownikow { get; internal set; }
    }
}