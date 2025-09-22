using System.Threading;
using System.Threading.Tasks;
using Application.Repositories;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQueryHandler : IRequestHandler<GetAutomovilByIdQuery, Automovil>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByIdQueryHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Automovil> Handle(GetAutomovilByIdQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.GetByIdAsync(request.Id);
            return automovil;
        }
    }
}