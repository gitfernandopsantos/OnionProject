using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionAPI.Data;
using OnionAPI.Data.Dtos;
using OnionAPI.Models;

namespace OnionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {
        private PostgreSqlContext _postgreSqlContext;
        private IMapper _mapper;

        public VendasController(PostgreSqlContext postgreSqlContext, IMapper mapper)
        {
            _postgreSqlContext = postgreSqlContext;
            _mapper = mapper;
        }
        //private static List<Produto> produtos = new List<Produto>();

        [HttpPost]
        public IActionResult AdicionaVendas([FromBody] ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);

            _postgreSqlContext.Produtos.Add(produto);
            _postgreSqlContext.SaveChanges();
            
            return CreatedAtAction(nameof(RecuperaVendasPorId), 
                new { idProduto = produto.IdProduto},
                produto);
        }

        [HttpGet]
        public IActionResult RecuperaVendas(Produto produto)
        {
            return NotFound();
        }

        [HttpGet("{idProduto}")]
        public IActionResult RecuperaVendasPorId(int idProduto)
        {
            var produto = _postgreSqlContext.Produtos.FirstOrDefault(produto => produto.IdProduto == idProduto);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }
    }
}
