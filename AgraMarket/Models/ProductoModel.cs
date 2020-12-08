using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class Producto 
    {
        public string nombre { get; set; }
        public long idVendedor { get; set;}
        public int precio { get; set; }
        public int cantidad { get; set; }

    }
}