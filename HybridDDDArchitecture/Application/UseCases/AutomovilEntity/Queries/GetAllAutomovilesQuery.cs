using MediatR;
using Domain.Entities;
using Core.Application;
using Application.DataTransferObjects;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQuery : QueryRequest<QueryResult<AutomovilDto>>
    {
    }
}