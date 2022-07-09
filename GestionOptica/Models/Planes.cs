using System.ComponentModel.DataAnnotations;

namespace GestionOptica.Models
{
    public class Planes
    {
        [Key]
        public int PlanesId { get; set; }
        public int ObraSocialId { get; set; }
        public string Descripcion { get; set; }
    }
}
