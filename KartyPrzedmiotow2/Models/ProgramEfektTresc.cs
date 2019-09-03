using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramEfektTresc
    {
        public ProgramEfektTresc()
        {
            
        }

        public int Id { get; set; }


        [ForeignKey("Tresci")]
        public int? TresciId { get; set; }
        public virtual Tresci Tresci { get; set; }

        [ForeignKey("Efekt")]
        public int ProgramEfektId { get; set; }
        public virtual ProgramEfekt Efekt { get; set; }


    }
}