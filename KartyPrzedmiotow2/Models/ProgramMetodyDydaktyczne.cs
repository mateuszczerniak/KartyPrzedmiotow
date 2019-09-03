using System.ComponentModel.DataAnnotations.Schema;

namespace KartyPrzedmiotow2.Models
{
    public class ProgramMetodyDydaktyczne
    {
        public int Id { get; set; }
        public int Skrot { get; set; }
        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }
        [ForeignKey("MetodyDydaktyczne")]
        public int MetodyDydaktyczneId { get; set; }
        public virtual MetodyDydaktyczne MetodyDydaktyczne { get; set; }
    }
}