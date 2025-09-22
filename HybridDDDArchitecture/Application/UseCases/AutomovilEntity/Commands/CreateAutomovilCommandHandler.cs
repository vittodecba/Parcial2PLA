using System.Threading;
using System.Threading.Tasks;
using Application.Repositories;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class CreateAutomovilCommandHandler : IRequestHandler<CreateAutomovilCommand, Automovil>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public CreateAutomovilCommandHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Automovil> Handle(CreateAutomovilCommand request, CancellationToken cancellationToken)
        {
            var automovil = new Automovil
            {
                Marca = request.Marca,
                Modelo = request.Modelo,
                Color = request.Color,
                Fabricacion = request.Fabricacion,
                NumeroMotor = request.NumeroMotor,
                NumeroChasis = request.NumeroChasis
            };

            await _automovilRepository.AddAsync(automovil);
            return automovil;
        }
    }
}