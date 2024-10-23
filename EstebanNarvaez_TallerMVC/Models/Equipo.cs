using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstebanNarvaez_TallerMVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        public string NombreEquipo { get; set; }
        public string CiudadEquipo { get; set; }
        public int TitulosEquipo { get; set; }
        public bool AceptaExtranjeros {  get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio {  get; set; }
        public Estadio? Estadio { get; set; }

    }
}
