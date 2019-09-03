using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramEfektMetodaOceniania
    {
        public ProgramEfektMetodaOceniania()
        {
            
        }

        public int Id { get; set; }


        [ForeignKey("ProgramMetodyOceniania")]
        public int? ProgramMetodyOcenianiaId { get; set; }
        public virtual ProgramMetodyOceniania ProgramMetodyOceniania { get; set; }

        [ForeignKey("Efekt")]
        public int ProgramEfektId { get; set; }
        public virtual ProgramEfekt Efekt { get; set; }


    }
}