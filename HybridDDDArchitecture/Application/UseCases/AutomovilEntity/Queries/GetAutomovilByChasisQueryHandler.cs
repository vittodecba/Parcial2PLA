using Application.Repositories;
using Domain.Entities;
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
            var automovil = await _automovilRepository.GetByChasisAync(request.NumeroChasis);
            return automovil;
        }
    }
}