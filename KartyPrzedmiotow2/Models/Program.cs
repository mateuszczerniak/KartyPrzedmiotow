using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class Program
    {
        public Program()
        {
            LiczbyGodzin = new List<LiczbaGodzin>();
            Tresci = new List<Tresci>();
            Pytania = new List<Pytanie>();
            MetodyOceniania = new List<ProgramMetodyOceniania>();
            MetodyDydaktyczne = new List<ProgramMetodyDydaktyczne>();
            Efekty = new List<ProgramEfekt>();
        }

        public int Id { get; set; }
        [DisplayName("Nazwa przedmiotu")]
        public string Nazwa { get; set; }
        [DisplayName("Kod przedmiotu")]
        public string Kod { get; set; }
        [DisplayName("Przedmiot do wyboru")]
        public bool PrzedmiotDoWyboru { get; set; }
        public int ECTS { get; set; }
        public string WarunkiZaliczenia { get; set; }

        public virtual ICollection<Tresci> Tresci { get; set; }
        public virtual ICollection<Pytanie> Pytania { get; set; }
        public virtual ICollection<ProgramMetodyOceniania> MetodyOceniania { get; set; }
        public virtual ICollection<ProgramMetodyDydaktyczne> MetodyDydaktyczne { get; set; }
        public virtual ICollection<LiczbaGodzin> LiczbyGodzin { get; set; }
        public virtual ICollection<ProgramEfekt> Efekty { get; set; }
        
        public virtual PrzedmiotOpis PrzedmiotOpis { get; set; }

        [ForeignKey("Wykladowca")]
        public string WykladowcaId { get; set; }
        [DisplayName("Wykładowca")]
        public virtual Uzytkownik Wykladowca { get; set; }

        [ForeignKey("FormaZaliczenia")]
        public int FormaZaliczeniaId { get; set; }
        public virtual FormaZaliczenia FormaZaliczenia { get; set; }

        [ForeignKey("Specjalnosc")]
        public int SpecjalnoscId { get; set; }
        [DisplayName("Specjalność")]
        public virtual Specjalnosc Specjalnosc { get; set; }

        [ForeignKey("Semestr")]
        public int SemestrId { get; set; }
        public virtual Semestr Semestr { get; set; }

        [ForeignKey("GrupaPrzedmiotow")]
        public int GrupaPrzedmiotowId { get; set; }
        public virtual GrupaPrzedmiotow GrupaPrzedmiotow { get; set; }

        [ForeignKey("ObszarKsztalcenia")]
        public int ObszarKsztalceniaId { get; set; }
        public virtual ObszarKsztalcenia ObszarKsztalcenia { get; set; }

        [ForeignKey("ProfilKsztalcenia")]
        public int ProfilKsztalceniaId { get; set; }
        public virtual ProfilKsztalcenia ProfilKsztalcenia { get; set; }

        [ForeignKey("Poziom")]
        public int PoziomId { get; set; }
        public virtual Poziom Poziom { get; set; }

        [ForeignKey("Kierunek")]
        public int KierunekId { get; set; }
        public virtual Kierunek Kierunek { get; set; }

        [ForeignKey("Wydzial")]
        public int WydzialId { get; set; }
        [DisplayName("Wydział")]
        public virtual Wydzial Wydzial { get; set; }
        public DateTime? Usuniety { get; set; }
    }
}