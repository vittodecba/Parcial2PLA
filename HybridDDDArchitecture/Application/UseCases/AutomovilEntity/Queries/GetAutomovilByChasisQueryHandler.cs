using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Core.Application;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQueryHandler
        : IRequestHandler<GetAutomovilByChasisQuery, AutomovilDto>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAutomovilByChasisQueryHandler(IAutomovilRepository automovilRepository)
            => _automovilRepository = automovilRepository;

        public async Task<AutomovilDto> Handle(GetAutomovilByChasisQuery request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.GetByChasisAync(request.NUMEROCHASIS)
                             ?? throw new EntityDoesNotExistException();

            return CustomMapper.Instance.Map<AutomovilDto>(automovil);
        }
    }
}
