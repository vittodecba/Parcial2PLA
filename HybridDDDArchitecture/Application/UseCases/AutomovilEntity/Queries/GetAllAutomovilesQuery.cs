using MediatR;
using Domain.Entities;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQuery : IRequest<List<Automovil>>
    {
    }
}