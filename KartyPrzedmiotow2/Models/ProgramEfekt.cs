using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramEfekt
    {
        public ProgramEfekt()
        {
            
        }

        public int Id { get; set; }

        public bool WymaganiaWstepne { get; set; }
        public string PrzedmiotoweEfektyKsztalcenia { get; set; }


        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }

        [ForeignKey("Efekt")]
        public int? EfektId { get; set; }
        public virtual Efekt Efekt { get; set; }

        public virtual ICollection<ProgramEfektTresc> Tresci { get; set; }
        public virtual ICollection<ProgramEfektMetodaDydaktyczna> MetodyDydaktyczne { get; set; }
        public virtual ICollection<ProgramEfektMetodaOceniania> MetodyOceniania { get; set; }
    }
}