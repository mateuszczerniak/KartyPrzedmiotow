using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class UzytkownikWydzialy
    {
        public int Id { get; set; }

        [ForeignKey("Wydzial")]
        public int WydzialId { get; set; }
        public virtual Wydzial Wydzial { get; set; }
        [ForeignKey("Uzytkownik")]
        public string UserId { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
    }
}