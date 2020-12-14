using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class ProductoModel
    {  
        [Key]
        public long Id { get; set; }
        public long IdVendedor { get; set; } //Este es el foreign key
        public string NomProducto { get; set; }
        public string TipoProducto { get; set; } //breve descripcion del producto (por ejemplo fruta)
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
}