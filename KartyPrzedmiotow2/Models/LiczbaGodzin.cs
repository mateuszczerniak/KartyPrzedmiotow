using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class LiczbaGodzin
    {
        public LiczbaGodzin()
        {
            FormaPracyGodziny = new List<ProgramFormaPracyGodzina>();
        }

        public int Id { get; set; }
        public int Stacjonarne { get; set; }
        public int Niestacjonarne { get; set; }

        [ForeignKey("TypLiczabGodzin")]
        public int TypLiczbaGodzinId { get; set; }
        public virtual TypLiczbaGodzin TypLiczabGodzin { get; set; }

        public virtual List<ProgramFormaPracyGodzina> FormaPracyGodziny { get; set; }


        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
    }
}