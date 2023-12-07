namespace OnionAPI.Models
{
    public class Pedido
    {
        public Pedido(int idPedido, int idProduto, float numeroPedido, DateTime dataEntrega, double frete)
        {
            this.IdPedido = idPedido;
            this.IdProduto = idProduto;
            this.NumeroPedido = numeroPedido;
            this.Frete = frete;
            this.DataEntrega = dataEntrega;
        }

        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public float NumeroPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public double Frete { get; set; }
    }
}
