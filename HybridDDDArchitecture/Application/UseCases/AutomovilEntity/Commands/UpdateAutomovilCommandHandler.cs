// HANDLER
using Application.Constants;
using Application.DomainEvents.Auomovil;
using Application.Exceptions;
using Application.Repositories;
using Core.Application;
using Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public sealed class UpdateAutomovilCommandHandler
        : IRequestCommandHandler<UpdateAutomovilCommand>
    {
        private readonly IAutomovilRepository _automovilRepository;
        private readonly ICommandQueryBus _domainbus;

        public UpdateAutomovilCommandHandler(ICommandQueryBus domainbus, IAutomovilRepository repo)
        {
            _domainbus = domainbus ?? throw new ArgumentNullException(nameof(domainbus));
            _automovilRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public async Task<Automovil> Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            var entity = await _automovilRepository.FindOneAsync(request.ID)
                         ?? throw new InvalidEntityDataException("Automóvil no encontrado");

            entity.setcolor(request.Color);
            if (!string.IsNullOrWhiteSpace(request.NumeroMotor))
                entity.setnumeromotor(request.NumeroMotor);

            try
            {
                _automovilRepository.Update(request.ID, entity); // si no es async, llamá Update y quitá await
                await _domainbus.Publish(new AutomovilEntityUpdate(entity.Id), cancellationToken);
                return entity;
            }
            catch (Exception ex)
            {
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex);
            }
        }

       

       

      

        Task IRequestHandler<UpdateAutomovilCommand>.Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
