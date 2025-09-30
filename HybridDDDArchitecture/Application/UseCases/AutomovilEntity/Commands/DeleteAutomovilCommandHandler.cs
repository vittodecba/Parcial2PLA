// HANDLER
using Application.DomainEvents.Auomovil;
using Application.Repositories;
using Application.UseCases.DummyEntity.Commands.DeleteDummyEntity;
using Core.Application;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public sealed class DeleteAutomovilCommandHandler
        : IRequestCommandHandler<DeleteAutomovilCommand, Unit>
    {
        private readonly IAutomovilRepository _automovilRepository;
        private readonly ICommandQueryBus _domainbus;

        public DeleteAutomovilCommandHandler(ICommandQueryBus domain, IAutomovilRepository repo)
        {
            _domainbus = domain ?? throw new ArgumentNullException(nameof(domain));
            _automovilRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public async Task<Unit> Handle(DeleteAutomovilCommand request, CancellationToken cancellationToken)
        {
             _automovilRepository.Remove(request.ID); // si es sync: _automovilRepository.Remove(request.Id);
            await _domainbus.Publish(new AutomovilDelete(request.ID), cancellationToken);
            return Unit.Value;
        }

        public Task<Unit> Handle(DeleteDummyEntityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
