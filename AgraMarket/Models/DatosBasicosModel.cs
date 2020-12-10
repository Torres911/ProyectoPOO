using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class DatosBasicosModel
    {
        [Key]
        public string Id { get; set; }

        public string Nombre { get; set; }

        public string CC { get; set; }

        public int Edad { get; set; }

    }
}