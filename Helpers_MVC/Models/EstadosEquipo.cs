using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class EstadosEquipos
    {

        [Key]
        public int id_estados_equipo { get; set; }

        public string? descripcion { get; set; }

        public string? estado { get; set; }

    }
}
