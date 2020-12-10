using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class DatosPagoModel
    {
        [Key]
        public string Id { get; set; }

        public long IdTarjetaCredito { get; set; }

        public long IdCuentaBancaria { get; set; }

        public long IdPaypal { get; set; }
    }
}