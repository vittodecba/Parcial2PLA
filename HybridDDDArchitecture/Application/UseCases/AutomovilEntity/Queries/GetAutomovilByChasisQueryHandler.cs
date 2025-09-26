using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQueryHandler : IRequestHandler<GetAutomovilByChasisQuery, AutomovilDto>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByChasisQueryHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Automovil> Handle(GetAutomovilByChasisQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.GetByChasisAync(request.NumeroChasis) ?? throw new EntityDoesNotExistException();
            return automovil;
        }

        Task<AutomovilDto> IRequestHandler<GetAutomovilByChasisQuery, AutomovilDto>.Handle(GetAutomovilByChasisQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}