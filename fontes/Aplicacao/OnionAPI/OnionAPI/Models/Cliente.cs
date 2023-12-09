using System.ComponentModel.DataAnnotations;

namespace OnionAPI.Models
{

    public class Cliente
    {
        [Key]
        [Required]
        public string Documento { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Localidade { get; set; }
        public string Uf { get; set; }
        [Required]
        public string Cep { get; set; }
    }
}
