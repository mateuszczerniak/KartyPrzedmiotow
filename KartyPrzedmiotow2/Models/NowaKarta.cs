using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Models
{
    public class NowaKarta
    {
        public List<NowaKartaWydzial> Wydzialy { get; set; }
        public List<SelectListItem> Poziomy { get; set; }
        public List<SelectListItem> ProfileKsztalcenia { get; set; }
        public List<SelectListItem> ObszaryKsztalcenia { get; set; }
        public List<SelectListItem> GrupyPrzedmiotow { get; set; }
        public List<SelectListItem> Semestry { get; set; }
        public List<SelectListItem> FormyZaliczenia { get; set; }
        public List<SelectListItem> Wykladowcy { get; set; }
        
        public int Id { get; set; }
        public int WydzialId { get; set; }
        public int KierunekId { get; set; }
        public int PoziomId { get; set; }
        public int ProfilKsztalceniaId { get; set; }
        public int ObszarKsztalceniaId { get; set; }
        public int GrupaPrzedmiotowId { get; set; }
        public int SpecjalnoscId { get; set; }
        public int SemestrId { get; set; }
        public int FormaZaliczeniaId { get; set; }
        public string WykladowcaId { get; set; }

        public string Kod { get; set; }
        public string NazwaPrzedmiotu { get; set; }
        public string NazwaSpecjalnosci { get;set; }
        public bool DoWyboru { get; set; }
        public int ECTS { get; set; }

        public List<Godzina> Godziny { get; set; }
    }
}