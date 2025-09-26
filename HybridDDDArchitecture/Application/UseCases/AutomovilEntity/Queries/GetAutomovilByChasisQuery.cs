using MediatR;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using Application.DataTransferObjects;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAutomovilByChasisQuery : IRequest<AutomovilDto>
    {
        [Required]
        public string NUMEROCHASIS { get; set; }
    }
}