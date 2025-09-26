using Core.Application;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class DeleteAutomovilCommand : IRequestCommand<Unit>
    {
        [Required]
        public string Id { get; set; }

        public DeleteAutomovilCommand()
        {
            
        }
    }
}