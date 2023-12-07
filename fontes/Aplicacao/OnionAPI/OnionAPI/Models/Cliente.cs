namespace OnionAPI.Models
{

    public class Cliente
    {
        public Cliente(string cpf, string razaoSocial, string logradouro, string bairro, string localidade, string uf, string cep)
        {
            this.Cpf = cpf;
            this.RazaoSocial = razaoSocial;
            this.Logradouro = logradouro;
            this.Localidade = localidade;   
            this.Bairro = bairro;
            this.Cep = cep;
            this.Uf = uf;
        }

        public string Cpf { get; set; }
        public string RazaoSocial { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}
