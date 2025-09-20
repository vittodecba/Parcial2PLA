using Application.Repositories;
using Core.Infraestructure.Repositories.Sql;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Sql
{
    internal sealed class AutomovilRepository(StoreDbContext context) : BaseRepository<Automovil>(context), IAutomovilRepository
    {
        public Task<Automovil> GetByChasisAync(string numeroChasis)
        {
            // Agrega la lógica de consulta a la base de datos acá 
            throw new NotImplementedException();
        }
    }
}
