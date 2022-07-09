using System.ComponentModel.DataAnnotations;

namespace GestionOptica.Models
{
    public class Localidad
    {
        [Key]
        public int LocalidadId { get; set; }
        public int ProvinciaId { get; set; }
        public string Descripcion { get; set;}

    }
}
