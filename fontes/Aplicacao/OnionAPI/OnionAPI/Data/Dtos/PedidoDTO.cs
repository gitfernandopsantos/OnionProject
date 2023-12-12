using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnionAPI.Data.Dtos
{
    public class PedidoDTO
    {
        [Required]
        public float NumeroPedido { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        public double Frete { get; set; }
    }
}
