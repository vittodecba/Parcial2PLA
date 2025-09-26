using Application.DomainEvents;
using Application.DomainEvents.Auomovil;
using Application.Repositories;
using Core.Application;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class DeleteAutomovilCommandHandler(ICommandQueryBus domain , IAutomovilRepository repo) : IRequestHandler<DeleteAutomovilCommand>
    {
        private readonly IAutomovilRepository _automovilRepository=repo ?? throw new ArgumentNullException(nameof(repo));
        private readonly ICommandQueryBus _domainbus = domain ?? throw new ArgumentNullException(nameof(domain));

       

        public  Task<Unit> Handle(DeleteAutomovilCommand request, CancellationToken cancellationToken)
        {
             _automovilRepository.Remove(request.Id);
            _domainbus.Publish(new AutomovilDelete(request.Id), cancellationToken);
            return  Unit.Task;

        }

        Task IRequestHandler<DeleteAutomovilCommand>.Handle(DeleteAutomovilCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}