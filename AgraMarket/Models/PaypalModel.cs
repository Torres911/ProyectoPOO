using System.ComponentModel.DataAnnotations;

namespace AgraMarket.Models
{
    public class PayPalModel
    {
        [Key]
        public string Id { get; set; }

        public string User { get; set; }
        public int Monto { get; set; }
    }
}