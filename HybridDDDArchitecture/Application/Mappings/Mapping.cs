using Application.DataTransferObjects;
using Application.DomainEvents;
using Application.DomainEvents.Auomovil;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    /// <summary>
    /// El mapeo entre objetos debe ir definido aqui
    /// </summary>
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<DummyEntity, DummyEntityCreated>().ReverseMap();
            CreateMap<DummyEntity, DummyEntityUpdated>().ReverseMap();
            CreateMap<DummyEntity, DummyEntityDto>().ReverseMap();

            CreateMap<Automovil,AutomovilDelete>().ReverseMap();
            CreateMap<Automovil,AutomovilEntityUpdate>().ReverseMap();
            CreateMap<Automovil , AutomovilCreate>().ReverseMap();
            CreateMap<Automovil, AutomovilDto>().ReverseMap();
            // arriba ya tenés otros CreateMap...
            CreateMap<Automovil, AutomovilDto>().ReverseMap();
            CreateMap<Automovil, AutomovilDto>().ReverseMap();


        }
    }
}
