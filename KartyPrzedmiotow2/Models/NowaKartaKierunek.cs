using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class NowaKartaKierunek
    {
        public string Nazwa { get; internal set; }
        public int Id { get; internal set; }
        public IEnumerable<NowaKartaSpecjalnosc> Specjalnosci { get; internal set; }
    }
}