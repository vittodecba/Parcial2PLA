using Application.Repositories;
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
             _automovilRepository.Remove(request.Id);
            return Unit.Value;
        }

        Task IRequestHandler<DeleteAutomovilCommand>.Handle(DeleteAutomovilCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}