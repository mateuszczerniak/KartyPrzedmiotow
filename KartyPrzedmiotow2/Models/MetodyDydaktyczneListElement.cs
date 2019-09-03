using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class MetodyDydaktyczneListElement
    {
        public MetodyDydaktyczneListElement()
        {

        }

        public int Id { get; set; }
        public int IdGrupy { get; set; }
        public string Grupa { get; set; }
        public string Nazwa { get; set; }
        [DisplayName("Liczba programów")]
        public int LiczbaProgramow { get; set; }
    }
}