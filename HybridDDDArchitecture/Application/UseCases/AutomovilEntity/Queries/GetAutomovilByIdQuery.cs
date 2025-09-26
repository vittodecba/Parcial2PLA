using MediatR;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using Application.DataTransferObjects;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByIdQuery : IRequest<AutomovilDto>
    {
        [Required]
        public string ID { get; set; }
    }
}