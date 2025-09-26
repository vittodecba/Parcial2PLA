// COMMAND
using Core.Application;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    // Un solo miembro: Id. Nada más.
    public class DeleteAutomovilCommand : IRequestCommand<Unit>

    {
    
          [Required]
         public string ID { get; set; }
        public DeleteAutomovilCommand()
        {
            
        }

    }


}

    
    



