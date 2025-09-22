using MediatR;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Application.Repositories;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQueryHandler : IRequestHandler<GetAllAutomovilesQuery, List<Automovil>>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAllAutomovilesQueryHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<List<Automovil>> Handle(GetAllAutomovilesQuery request, CancellationToken cancellationToken)
        {
            return (await _automovilRepository.GetAllAsync()).ToList();
        }
    }
}