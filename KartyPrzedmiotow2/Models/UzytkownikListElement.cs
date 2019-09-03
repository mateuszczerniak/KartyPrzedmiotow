using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class UzytkownikListElement
    {
        [DisplayName("Imię")]
        public string Imie { get; internal set; }
        [DisplayName("Nazwisko")]
        public string Nazwisko { get; internal set; }
        [DisplayName("Tytuły")]
        public string Tytuly { get; internal set; }
        [DisplayName("Role")]
        public string Role { get; internal set; }
        [DisplayName("Wydziały")]
        public string Wydzialy { get; internal set; }
        public string Id { get; internal set; }
    }
}