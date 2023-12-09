using System.ComponentModel.DataAnnotations;

namespace OnionAPI.Data.Dtos
{
    public class ClienteDTO
    {
        [Key]
        [Required(ErrorMessage ="Digite seu CPF ou um CPNJ no campo documento para realizar o seu registro.")]
        [StringLength(14,ErrorMessage ="O Documento não pode passar de 14 caracteres.")]
        public string Documento { get; set; }
        [Required(ErrorMessage ="Preencha o campo Razão Social com seu Nome.")]
        [StringLength(200,ErrorMessage = "Ops, você ultrapassou o limite de 200 caracteres. Abreviação é valida também.")]
        public string RazaoSocial { get; set; }
        [Required]
        [StringLength(200,ErrorMessage = "Ops, você ultrapassou o limite de 200 caracteres. Abreviação é valida também.")]
        public string Logradouro { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Ops, você ultrapassou o limite de 50 caracteres. Abreviação é valida também.")]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Ops, você ultrapassou o limite de 50 caracteres. Abreviação é valida também.")]
        public string Localidade { get; set; }
        [StringLength(14, ErrorMessage = "Desculpe, não consegui realizar o cadastro o campo UF é permitido somente 14 caracteres")]
        public string Uf { get; set; }

        [StringLength(8, ErrorMessage = "Ops, você ultrapassou o limite de 8 caracteres. Favor digitar somente os números do seu cep")]
        [Required]
        public string Cep { get; set; }
    }
}
