using System.Threading;
using System.Threading.Tasks;
using Application.Repositories;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class DeleteAutomovilCommandHandler : IRequestHandler<DeleteAutomovilCommand>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public DeleteAutomovilCommandHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Unit> Handle(DeleteAutomovilCommand request, CancellationToken cancellationToken)
        {
            await _automovilRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}