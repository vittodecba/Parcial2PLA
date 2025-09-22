using MediatR;
using HybridDODArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQuery : IRequest<List<Automovil>>
    {
    }
}