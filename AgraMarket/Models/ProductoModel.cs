using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class ProductoModel
    {  
        [Key]
        public long Id { get; set; }
        public long IdGranjero { get; set; }
        public string NomProducto { get; set; }
        public string FotoProducto { get; set; }
        public int ValorProducto { get; set; }
        public int Cantidad { get; set; }
    }
}