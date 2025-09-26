using Core.Application;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class UpdateAutomovilCommand : IRequestCommand
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Color { get; set; }
        
        public string NumeroMotor { get; set; }

        public UpdateAutomovilCommand()
        {
            
        }


    }
}