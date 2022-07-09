using System;
using System.ComponentModel.DataAnnotations;

namespace GestionOptica.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string ApellidoNombre { get; set; }

        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public int ObraSocialId { get; set; }
        public int PlanesId { get; set; }
        public int Documento { get; set; }
        public int TipoDocumentoId { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public DateTime FechaNacimiento { get; set; }= DateTime.Now;
        public int EstadoClientId { get; set; }
        public string DNI { get; set; }
    }
}
