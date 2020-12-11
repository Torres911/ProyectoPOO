using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class UsuarioModel
    {
        [Key]
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 
        public string CC { get; set; }
        public int Edad { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Dirección { get; set; }
        public string TipoUsuario { get; set; } 
        public long IdDatosPago { get; set; }
    }
}

