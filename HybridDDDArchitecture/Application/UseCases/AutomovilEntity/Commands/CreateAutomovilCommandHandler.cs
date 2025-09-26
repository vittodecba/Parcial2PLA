using Application.ApplicationServices;
using Application.Constants;
using Application.DomainEvents;
using Application.DomainEvents.Auomovil;
using Application.Exceptions;
using Application.Repositories;
using Application.UseCases.AutomovilEntity.Commands.CreateDummyEntity;
using Core.Application;
using Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class CreateAutomovilCommandHandler(ICommandQueryBus domain ,IAutomovilRepository repo ,IAutomovilApplivationService servicio ) : IRequestCommandHandler<CreateAutomovilCommand, string>
    {
        private readonly IAutomovilRepository _automovilRepository = repo ?? throw new ArgumentNullException(nameof(repo));
        private readonly IAutomovilApplivationService service = servicio ?? throw new ArgumentNullException( nameof(servicio));
        private readonly ICommandQueryBus _domainbus = domain ?? throw new ArgumentNullException(nameof(domain));

       

        public async Task<string> Handle(CreateAutomovilCommand request, CancellationToken cancellationToken)
        {
            Automovil entity = new(request.Color, request.NumeroMotor, request.Marca, request.NumeroChasis, request.Modelo, request.Fabricacion);
            if(!entity.IsValid) throw new InvalidEntityDataException(entity.GetErrors());

            if (service.AutomovilExist(entity.Id)) throw new EntityDoesExistException();

            try
            {
                object createdId = await repo.AddAsync(entity);

                await _domainbus.Publish(entity.To<AutomovilCreate>(), cancellationToken);

                return createdId.ToString();
            }
            catch (Exception ex)
            {
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex.InnerException);
            }


        }

        
    }
}