using MediatR;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQuery : IRequest<Automovil>
    {
        [Required]
        public string NumeroChasis { get; set; }
    }
}