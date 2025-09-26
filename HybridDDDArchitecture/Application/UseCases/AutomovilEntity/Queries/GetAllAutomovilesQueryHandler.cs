using MediatR;
using Application.Repositories;
using Domain.Entities;
using Application.Exceptions;
using Core.Application;
using Application.DataTransferObjects;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQueryHandler(IAutomovilRepository context): IRequestHandler<GetAllAutomovilesQuery, QueryResult<AutomovilDto>>
    {
        private readonly IAutomovilRepository _automovilRepository;

       

        public async Task<List<Automovil>> Handle(GetAllAutomovilesQuery request, CancellationToken cancellationToken)
        {
            return (await _automovilRepository.FindAllAsync()).ToList() ?? throw new EntityDoesNotExistException();
        }

        Task<QueryResult<AutomovilDto>> IRequestHandler<GetAllAutomovilesQuery, QueryResult<AutomovilDto>>.Handle(GetAllAutomovilesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}