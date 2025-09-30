// COMMAND
using Core.Application;
using Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class UpdateAutomovilCommand : IRequestCommand<Automovil>
    {
        [Required] public string ID { get; set; }
        [Required] public string Color { get; set; }
        public string? NumeroMotor { get; set; }
    }
}
