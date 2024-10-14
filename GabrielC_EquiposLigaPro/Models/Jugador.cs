using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GabrielC_EquiposLigaPro.Models
{
    public class Jugador
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad {  get; set; }
        [ForeignKey("Equipo")]
        public int IDEquipo { get; set; }
        [ForeignKey("Estadio")]
        public int IDEstadio { get; set; }
    }
}
