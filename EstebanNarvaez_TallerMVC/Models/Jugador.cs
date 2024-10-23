using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstebanNarvaez_TallerMVC.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string NombreJugador { get; set; }
        public string Posicion {  get; set; }
        public int Edad {  get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public Equipo Equipo { get; set; }

    }
}
