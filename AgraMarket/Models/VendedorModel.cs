using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class Vendedor
    {
        public string nombreVendedor { get; set; }
        public string nombreUsario { get; set; }
        public string contrasena {get; set; }
        public long idVendedor { get; set; }
        public List<Producto> listaProductos { get; set; }
    }
}