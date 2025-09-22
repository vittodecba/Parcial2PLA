using MediatR;
using HybridDODArchitecture.Domain.Entities;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQuery : IRequest<Automovil>
    {
        public int Id { get; set; }
    }
}