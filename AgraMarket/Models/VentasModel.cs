using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class VentasModel
    {
        [Key]
        public long Id { get; set; }

        public long IdVendedor { get; set; }
        
        public string NomProducto { get; set; }

        public string NomVendedor { get; set; }

        public int Cantidad { get; set; }
        public string DirEntrega { get; set; }

        public DateTime FechaEntrega { get; set; }
    } 
}