﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionAPI.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int IdPedido { get; set; }
        [Required]
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        [Required]
        public float NumeroPedido { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        public double Frete { get; set; }
    }
}
