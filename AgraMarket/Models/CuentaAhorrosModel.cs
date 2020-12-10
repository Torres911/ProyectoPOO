using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class CuentaAhorrosModel
    {
        [Key]
        public string Id { get; set; }
        
        public string NumeroCuenta { get; set; }

        public int Monto { get; set; }
    }
}