using MediatR;
using Application.Repositories;
using Core.Application;
using Application.DataTransferObjects;

namespace HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries
{
    public class GetAllAutomovilesQueryHandler
        : IRequestHandler<GetAllAutomovilesQuery, QueryResult<AutomovilDto>>
    {
        private readonly IAutomovilRepository _automovilRepository;

        public GetAllAutomovilesQueryHandler(IAutomovilRepository context)
        {
            _automovilRepository = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<QueryResult<AutomovilDto>> Handle(GetAllAutomovilesQuery request, CancellationToken cancellationToken)
        {
            // Trae todo (o reemplazá por un método paginado en el repo si tenés)
            var entities = await _automovilRepository.FindAllAsync();

            // Map a DTO (usa CustomMapper.Instance configurado en Startup)
            var items = entities.Select(e => CustomMapper.Instance.Map<AutomovilDto>(e)).ToList();

            // Paginado simple en memoria (si tu repo no pagina)
            var pageIndex = (int)Math.Max(1, request.PageIndex);
            var pageSize = (int)Math.Max(1, request.PageSize);
            var total = items.Count;

            var paged = items
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new QueryResult<AutomovilDto>(
     items: paged,
     count: (long)total,
     pageSize: (uint)pageSize,
     pageIndex: (uint)pageIndex
 );


        }
    }
}
