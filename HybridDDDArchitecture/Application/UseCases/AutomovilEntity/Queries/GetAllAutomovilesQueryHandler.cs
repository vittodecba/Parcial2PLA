using MediatR;
using Application.Repositories;
using Domain.Entities;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQueryHandler(IAutomovilRepository context): IRequestHandler<GetAllAutomovilesQuery, List<Automovil>>
    {
        private readonly IAutomovilRepository _automovilRepository;

       

        public async Task<List<Automovil>> Handle(GetAllAutomovilesQuery request, CancellationToken cancellationToken)
        {
            return (await _automovilRepository.FindAllAsync()).ToList();
        }
    }
}