using Core.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Linq.Expressions;


namespace Application.Repositories
{
    public interface IAutomovilRepository : IRepository<Automovil>
    {
        Task<Automovil> GetByChasisAync(string numeroChasis);
        Task<IEnumerable<Automovil>> GetallAsync();
    }
}
