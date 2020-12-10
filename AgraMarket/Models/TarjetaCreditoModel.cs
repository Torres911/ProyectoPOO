using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class TarjetaCreditoModel
    {
        [Key]
        public string Id { get; set; }

        public string NumeroTarjeta { get; set; }

        public string NombreTarjeta { get; set; }

        public int Cupo { get; set; }

    }
}