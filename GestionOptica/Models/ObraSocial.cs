using System.ComponentModel.DataAnnotations;

namespace GestionOptica.Models
{
    public class ObraSocial
    {
        [Key]
        public int ObraSocialId { get; set; }
        public string Descripcion { get; set; }
    }
}
