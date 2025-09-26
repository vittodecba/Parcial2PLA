using Application.ApplicationServices;
using Application.Repositories;
using Core.Application;
using Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class CreateAutomovilCommandHandler(ICommandQueryBus domain ,IAutomovilRepository repo ,IAutomovilApplivationService servicio ) : IRequestHandler<CreateAutomovilCommand, Automovil>
    {
        private readonly IAutomovilRepository _automovilRepository;

       

        public async Task<Automovil> Handle(CreateAutomovilCommand request, CancellationToken cancellationToken)
        {
            var automovil = new Automovil
            {
                Marca = request.Marca,
                Modelo = request.Modelo,
                color = request.Color,
                Año_Fabrcacion = request.Fabricacion,
                Numero_Motor = request.NumeroMotor,
                Numero_Chasis = request.NumeroChasis
            };

            await _automovilRepository.AddAsync(automovil);
            return automovil;
        }
    }
}