using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class TipoEquipos
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public string? descripcion { get; set; }
        public string? estado { get; set; }
    }
}
