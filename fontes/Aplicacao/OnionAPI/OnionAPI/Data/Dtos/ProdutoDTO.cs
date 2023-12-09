using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnionAPI.Data.Dtos
{
    public class ProdutoDTO
    {
        [Required]
        public string TipoProduto { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [ForeignKey("Cliente")]
        public string DocumentoCliente { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
