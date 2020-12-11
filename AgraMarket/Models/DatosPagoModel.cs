using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class DatosPagoModel
    {
        [Key]
        public long Id { get; set; }
        public long NumeroTarjetaCredito { get; set; }
        public string NombreTarjetaCredito { get; set; }
        public int CupoTarjetaCredito { get; set; }
        public string UserPaypal { get; set; }
        public int MontoPaypal { get; set; }
        public string NumeroCuentaAhorros { get; set; }
        public int MontoAhorros { get; set; }

    }
}