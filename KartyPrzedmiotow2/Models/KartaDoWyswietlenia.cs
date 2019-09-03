using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaDoWyswietlenia
    {
        [Display(Name = "Nazwa przedmiotu")]
        public string NazwaPrzedmiotu { get; internal set; }
        [Display(Name = "Nazwa angielska")]
        public string NazwaPrzedmiotuAng { get; internal set; }
        public List<KartaDoWyswietleniaMetodyDydaktyczne> MetodyDydaktyczne { get; internal set; }
        public List<KartaDoWyswietleniaMetodyOceniania> MetodyOceniania { get; internal set; }
        public List<KartaDoWyswietleniaFormaPracy> FormaPracyStacjonarne { get; internal set; }
        public List<KartaDoWyswietleniaFormaPracy> FormaPracyZaoczne { get; internal set; }
        [Display(Name = "Nazwa podstawowej jednostki prowadzącej przedmiot")]
        public string Wydzial { get; internal set; }
        [Display(Name = "Rok akademicki")]
        public string Rok { get; internal set; }
        public string Kierunek { get; internal set; }
        public string Poziom { get; internal set; }
        public string Profil { get; internal set; }
        [Display(Name = "Grupa przedmiotów")]
        public string GrupaPrzedmiotow { get; internal set; }
        public string Semestr { get; internal set; }
        [Display(Name = "Forma zaliczenia")]
        public string FormaZaliczenia { get; internal set; }
        [Display(Name = "Punkty ECTS")]
        public int PunktyECTS { get; internal set; }
        [Display(Name = "Przedmiot do wyboru")]
        public bool PrzedmiotDoWyboru { get; internal set; }
        [Display(Name = "Język zajęć")]
        public string JezykZajec { get; internal set; }
        [Display(Name = "Specjalność")]
        public string Specjalnosc { get; internal set; }
        [Display(Name = "Nazwisko osoby odpowiedzialnej za przedmiot")]
        public string Prowadzacy { get; internal set; }
        [Display(Name = "Opis przedmiotu")]
        public string OpisPrzedmiotu { get; internal set; }
        public string CelGlowny { get; internal set; }
        public string CelWiedza { get; internal set; }
        public string CelUmiejetnosci { get; internal set; }
        public string CelKompetencje { get; internal set; }
        public List<KartaDoWyswietleniaTresci> Tresci { get; set; }
        public List<KartaDoWyswietleniaLiteratura> Literatura { get; set; }
        [Display(Name = "Warunki zaliczenia")]
        public string WarunkiZaliczenia { get; internal set; }
        public List<KartaDoWyswietleniaPytania> Pytania { get; internal set; }
        public List<KartaDoWyswietleniaLiczbaGodzin> Godziny { get; internal set; }
        public bool PDF { get; internal set; }
        public int Id { get; internal set; }
        public List<KartaDoWyswietleniaEfekt> Efekty { get; internal set; }
    }
}