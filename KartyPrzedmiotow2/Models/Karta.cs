using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Models
{
    public class Karta
    {
        public Karta()
        {
            LiteraturyPodstawowe = new List<KartaLiteratura>();
            LiteraturyUzupelniajace = new List<KartaLiteratura>();
            ZrodlaDodatkowe = new List<KartaLiteratura>();
            Pytania = new List<KartaPytanie>();
            MetodyPodajaceIds = new List<WybranaMetoda>();
            MetodyPraktyczneIds = new List<WybranaMetoda>();
            MetodyProblemoweIds = new List<WybranaMetoda>();
            MetodyEksponujaceIds = new List<WybranaMetoda>();
            MetodyOcenianiaIds = new List<WybranaMetoda>();
        }

        public int ProgramId { get; set; }
        public int JezykiId { get; set; }
        public string NazwaAngielski { get; set; }
        public int MaterialyId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string KrotkiOpis { get; set; }
        public string Rok { get; set; }
        public string CelGlowny { get; set; }
        public string CelKompetencje { get; set; }
        public string CelUmiejetnosci { get; set; }
        public string CelWiedza { get; set; }
        public string WarunkiZaliczenia { get; set; }

        public List<KartaLiteratura> LiteraturyPodstawowe { get; set; }
        public List<KartaLiteratura> LiteraturyUzupelniajace { get; set; }
        public List<KartaLiteratura> ZrodlaDodatkowe { get; set; }
        public List<SelectListItem> Jezyki { get; set; }
        public List<SelectListItem> Materialy { get; set; }


        public List<WybranaMetoda> MetodyPodajaceIds { get; set; }
        public List<WybranaMetoda> MetodyPraktyczneIds { get; set; }
        public List<WybranaMetoda> MetodyProblemoweIds { get; set; }
        public List<WybranaMetoda> MetodyEksponujaceIds { get; set; }
        public List<WybranaMetoda> MetodyOcenianiaIds { get; set; }
        public List<SelectListItem> MetodyPodajace { get; set; }
        public List<SelectListItem> MetodyPraktyczne { get; set; }
        public List<SelectListItem> MetodyProblemowe { get; set; }
        public List<SelectListItem> MetodyEksponujace { get; set; }
        public List<SelectListItem> MetodyOceniania { get; set; }

        public List<KartaPytanie> Pytania { get; set; }
        public int WykladStacjonarne { get; set; }
        public List<KartaGodzina> Godziny { get; set; }
        public List<KartaEfekt> Efekty { get; set; }
        public List<KartaRodzajEfektu> RodzajeEfektow { get; set; }

        public List<KartaFormaPracy> FormaPracy { get; set; }
        public int ECTS { get; set; }
        public string Tytuly { get; set; }
    }
}