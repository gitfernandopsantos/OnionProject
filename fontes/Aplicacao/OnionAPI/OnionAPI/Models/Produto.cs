﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionAPI.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int IdProduto { get; set; }
        [Required]
        public string TipoProduto { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string DocumentoCliente { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
