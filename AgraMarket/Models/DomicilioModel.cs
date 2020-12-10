using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class DomicilioModel
    {
        [Key]
        public long Id { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Dirección { get; set; }
        public string TipoDireccion { get; set; }
        
    }
}