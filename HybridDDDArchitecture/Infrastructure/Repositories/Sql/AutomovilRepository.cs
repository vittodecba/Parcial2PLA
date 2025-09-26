using Application.Repositories;
using Core.Infraestructure.Repositories.Sql;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Sql
{
    internal sealed class AutomovilRepository(StoreDbContext context) : BaseRepository<Automovil>(context), IAutomovilRepository
    {
        public Task<IEnumerable<Automovil>> GetallAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Automovil> GetByChasisAync(string numeroChasis)
        {
         return await Context.Set<Automovil>().FirstOrDefaultAsync(a => a.Numero_Chasis== numeroChasis);


        }
    }
}
