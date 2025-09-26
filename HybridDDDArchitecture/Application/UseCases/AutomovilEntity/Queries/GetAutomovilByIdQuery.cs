using MediatR;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQuery : IRequest<Automovil>
    {
        [Required]
        public int Id { get; set; }
    }
}