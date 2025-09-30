using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Core.Application;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQueryHandler
        : IRequestHandler<GetAutomovilByIdQuery, AutomovilDto>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByIdQueryHandler(IAutomovilRepository automovilRepository)
            => _automovilRepository = automovilRepository;

        // Este es el ÚNICO Handle que debe quedar
        public async Task<AutomovilDto> Handle(GetAutomovilByIdQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.FindOneAsync(request.ID)
                             ?? throw new EntityDoesNotExistException($"No existe Automóvil con id '{request.ID}'.");

            return CustomMapper.Instance.Map<AutomovilDto>(automovil);
        }
    }
}
