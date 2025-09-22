using System.Threading;
using System.Threading.Tasks;
using Application.Repositories;
using HybridDODArchitecture.Application.Repositories;
using HybridDODArchitecture.Domain.Entities;
using MediatR;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class UpdateAutomovilCommandHandler : IRequestHandler<UpdateAutomovilCommand>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public UpdateAutomovilCommandHandler(IAutomovilRepository automovilRepository)
        {
            _automovilRepository = automovilRepository;
        }

        public async Task<Unit> Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            var automovil = await _automovilRepository.GetByIdAsync(request.Id);

            automovil.Marca = request.Marca;
            automovil.Modelo = request.Modelo;
            automovil.Color = request.Color;
            automovil.Fabricacion = request.Fabricacion;
            automovil.NumeroMotor = request.NumeroMotor;
            automovil.NumeroChasis = request.NumeroChasis;

            await _automovilRepository.UpdateAsync(automovil);
            return Unit.Value;
        }
    }
}