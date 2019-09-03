using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramMetodyOceniania
    {
        public int Id { get; set; }
        public int Skrot { get; set; }
        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
        [ForeignKey("MetodyOceniania")]
        public int MetodyOcenianiaId { get; set; }
        public virtual MetodyOceniania MetodyOceniania { get; set; }
    }
}