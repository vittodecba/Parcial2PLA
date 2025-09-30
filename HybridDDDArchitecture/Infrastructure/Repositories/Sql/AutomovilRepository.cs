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
        public async Task<bool> ExistsByChasisAsync(string numeroChasis)
       => await Context.Set<Automovil>()
                       .AnyAsync(a => a.Numero_Chasis == numeroChasis);


        public async Task<bool> ExistsByMotorAsync(string numeroMotor)
        => await Context.Set<Automovil>()
                        .AnyAsync(a => a.Numero_Motor == numeroMotor);

        public async Task<IEnumerable<Automovil>> GetallAsync()
        {
            return await Context.Set<Automovil>().AsNoTracking().ToListAsync();
        }

        public async Task<Automovil> GetByChasisAync(string numeroChasis)
        {
            return await Context.Set<Automovil>()
             .AsNoTracking()
             .FirstOrDefaultAsync(a => a.Numero_Chasis == numeroChasis);


        }
    }
}
