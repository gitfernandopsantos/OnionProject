using AutoMapper;
using OnionAPI.Data.Dtos;
using OnionAPI.Models;

namespace OnionAPI.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoDTO, Produto>();
        }
    }
}
