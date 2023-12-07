using Microsoft.AspNetCore.Mvc;
using OnionAPI.Models;

namespace OnionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();
        [HttpPost]
        public void AdicionaVendas([FromBody] Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine(produto.Valor);
            Console.WriteLine(produto.DocumentoCliente);
            Console.WriteLine(produto.Nome);
        }
    }
}
