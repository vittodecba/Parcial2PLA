using Core.Application;
using Domain.Entities;
using MediatR;


namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class CreateAutomovilCommand : IRequestCommand<string>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Fabricacion { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
    }
}