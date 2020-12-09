using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class Ventas
    {
        public string usuarioCliente { get; set; }

        public DateTime fechaCompra { get; set; }
        
        public Producto producto { get; set; }

        public int cantidadCompra { get; set; }
    } 
}