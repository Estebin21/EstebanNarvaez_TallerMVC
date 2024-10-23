using System.ComponentModel.DataAnnotations;

namespace EstebanNarvaez_TallerMVC.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        public string NombreEstadio { get; set; }
        public string DireccionEstadio { get; set; }
        public string CiudadEstadio {  get; set; }
        public int CapacidadEstadio { get; set; }
    }
}
