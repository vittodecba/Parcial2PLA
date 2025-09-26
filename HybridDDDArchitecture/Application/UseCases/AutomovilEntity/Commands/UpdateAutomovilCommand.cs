using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class UpdateAutomovilCommand : IRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Color { get; set; }
        
        public string NumeroMotor { get; set; }

       
       
    }
}