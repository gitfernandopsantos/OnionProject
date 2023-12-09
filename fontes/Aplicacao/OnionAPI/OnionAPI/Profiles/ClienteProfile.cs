using AutoMapper;
using OnionAPI.Data.Dtos;
using OnionAPI.Models;

namespace OnionAPI.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteDTO, Cliente>();
            
        }
    }
}
