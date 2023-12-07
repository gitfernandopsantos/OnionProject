namespace OnionAPI.Models
{
    public class Produto
    {
        public Produto(int idProduto, string nome, string documentoCliente, double valor)
        {
            this.IdProduto = idProduto;
            this.DocumentoCliente = documentoCliente;
            this.Nome = nome;
            this.Valor = valor;
        }
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string DocumentoCliente { get; set; }
        public double Valor { get; set; }
    }
}
