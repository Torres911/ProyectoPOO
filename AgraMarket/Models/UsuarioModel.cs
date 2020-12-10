using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class UsuarioModel
    {
        [Key]
        public long Id { get; set; }

        public string User { get; set; }

        public string Pass { get; set; }

        public string TipoUsuario { get; set; } 

        public long IdDatosBasicos { get; set; }

        public long IdDatosPago { get; set; }

        public long IdDomicilio { get; set; }
    }
}

