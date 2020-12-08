using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class Ventas
    {
        public string usuarioCliente { get; set; }

        public DateTime fechaCompra { get; set; }
        public List<Producto> listaVentas { get; set; }
    } 
}