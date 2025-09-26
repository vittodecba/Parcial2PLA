using Application.Constants;
using Application.DomainEvents;
using Application.DomainEvents.Auomovil;
using Application.Exceptions;
using Application.Repositories;
using Core.Application;
using Domain.Entities;
using MediatR;
using System.Threading;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class UpdateAutomovilCommandHandler(ICommandQueryBus domainbus , IAutomovilRepository context) : IRequestHandler<UpdateAutomovilCommand>
    {
        private readonly IAutomovilRepository _automovilRepository = context ?? throw new ArgumentNullException(nameof(context));
        private readonly ICommandQueryBus _domainbus = domainbus ?? throw new ArgumentNullException(nameof(domainbus));

        public async Task Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            Automovil entity = await _automovilRepository.FindOneAsync(request.Id) ?? throw new ArgumentNullException(nameof(request));
            entity.setcolor(request.Color);
            entity.setnumeromotor(request.NumeroMotor);


            try
            {
                _automovilRepository.Update(request.Id, entity);
                await _domainbus.Publish(entity.To<AutomovilEntityUpdate>(), cancellationToken);
            }
            catch (Exception ex)
            {
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex.InnerException);
            }
        }

        Task IRequestHandler<UpdateAutomovilCommand>.Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}