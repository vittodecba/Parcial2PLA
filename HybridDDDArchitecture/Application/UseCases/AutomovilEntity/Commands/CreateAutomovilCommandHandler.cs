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
            var entity = new Automovil(
                marca: request.Marca,
                modelo: request.Modelo,
                color: request.Color,
                año_Fabrcacion: request.Fabricacion,
                numero_Motor: request.NumeroMotor,
                numero_Chasis: request.NumeroChasis
            );

            if (!entity.IsValid) throw new InvalidEntityDataException(entity.GetErrors());

            // Validar duplicados por CHASIS y/o MOTOR:
            if (await repo.ExistsByChasisAsync(entity.Numero_Chasis))
                throw new EntityDoesExistException("Ya existe un automóvil con ese número de chasis.");

            if (await repo.ExistsByMotorAsync(entity.Numero_Motor))
                throw new EntityDoesExistException("Ya existe un automóvil con ese número de motor.");

            try
            {
                var createdId = await repo.AddAsync(entity);
                await _domainbus.Publish(entity.To<AutomovilCreate>(), cancellationToken);
                return createdId.ToString();
            }
            catch (Exception ex)
            {
                // Usá ex (no ex.InnerException que puede ser null)
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex);
            }
        }


    }
}