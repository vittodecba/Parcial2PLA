using MediatR;
using HybridDODArchitecture.Domain.Entities;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQuery : IRequest<Automovil>
    {
        public string NumeroChasis { get; set; }
    }
}