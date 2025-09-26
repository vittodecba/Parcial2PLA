using MediatR;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands
{
    public class DeleteAutomovilCommand : IRequest
    {
        [Required]
        public int Id { get; set; }
    }
}