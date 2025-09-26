using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQueryHandler : IRequestHandler<GetAutomovilByIdQuery, AutomovilDto>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByIdQueryHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Automovil> Handle(GetAutomovilByIdQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.FindOneAsync(request.ID) ?? throw new EntityDoesNotExistException();
            return automovil;
        }

        Task<AutomovilDto> IRequestHandler<GetAutomovilByIdQuery, AutomovilDto>.Handle(GetAutomovilByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}