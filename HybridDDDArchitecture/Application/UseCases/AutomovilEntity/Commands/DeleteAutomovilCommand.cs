using MediatR;
using HybridDODArchitecture.Domain.Entities;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class DeleteAutomovilCommand : IRequest
    {
        public int Id { get; set; }
    }
}