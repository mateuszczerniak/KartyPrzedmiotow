using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramEfektMetodaDydaktyczna
    {
        public ProgramEfektMetodaDydaktyczna()
        {
            
        }

        public int Id { get; set; }


        [ForeignKey("ProgramMetodyDydaktyczne")]
        public int? ProgramMetodyDydaktyczneId { get; set; }
        public virtual ProgramMetodyDydaktyczne ProgramMetodyDydaktyczne { get; set; }

        [ForeignKey("Efekt")]
        public int ProgramEfektId { get; set; }
        public virtual ProgramEfekt Efekt { get; set; }


    }
}