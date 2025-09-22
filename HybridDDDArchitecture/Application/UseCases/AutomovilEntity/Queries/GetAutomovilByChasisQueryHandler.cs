using System.Threading;
using System.Threading.Tasks;
using Application.Repositories;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQueryHandler : IRequestHandler<GetAutomovilByChasisQuery, Automovil>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByChasisQueryHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Automovil> Handle(GetAutomovilByChasisQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.GetByChasisAsync(request.NumeroChasis);
            return automovil;
        }
    }
}