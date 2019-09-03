using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class NowaKartaWydzial
    {
        public string Nazwa { get; internal set; }
        public int Id { get; internal set; }
        public IEnumerable<NowaKartaKierunek> Kierunki { get; internal set; }
    }
}