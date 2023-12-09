using AutoMapper;
using OnionAPI.Data.Dtos;
using OnionAPI.Models;

namespace OnionAPI.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<PedidoDTO, Pedido>();
            
        }
    }
}
