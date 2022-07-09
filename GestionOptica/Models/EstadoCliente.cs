using System.ComponentModel.DataAnnotations;

namespace GestionOptica.Models
{
    public class EstadoCliente
    {
        [Key]
        public int EstadoClienteId { get; set; }
        public string Descripcion { get; set; }
    }
}
