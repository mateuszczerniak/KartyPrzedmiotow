using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class KartaEfekt
    {
        public KartaEfekt()
        {
            WybraneMetodyPodajace = new List<int>();
            WybraneMetodyPraktyczne = new List<int>();
            WybraneMetodyProblemowe = new List<int>();
            WybraneMetodyEksponujace = new List<int>();
            WybraneMetodyOceniania = new List<int>();
        }

        public int Id { get; set; }
        public string Opis { get; set; }
        public string Skrot { get; set; }
        public int RodzajEfektuId { get; set; }

        public bool WymaganiaWstepne { get; set; }
        public string PrzedmiotoweEfektyKsztalcenia { get; set; }

        public IEnumerable<KartaEfektGodzina> Godziny { get; set; }

        public IEnumerable<int> WybraneMetodyPodajace { get; set; }
        public IEnumerable<int> WybraneMetodyPraktyczne { get; set; }
        public IEnumerable<int> WybraneMetodyProblemowe { get; set; }
        public IEnumerable<int> WybraneMetodyEksponujace { get; set; }
        public IEnumerable<int> WybraneMetodyOceniania { get; set; }


    }
}