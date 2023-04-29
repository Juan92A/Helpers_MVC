using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Marcas
    {
        [Key]
        [Display(Name = "ID")]

        public int id_marcas { get; set; }
        [Display(Name = "Nombre de Marca")]

        public string? nombre_marca { get; set; }
        [Display(Name = "Estado")]

        public string? estados { get; set; }
    }
}
