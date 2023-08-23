using Application.Context;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsRequest, List<GetAllProductsResponse>>
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetAllProductsResponse>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            return await _context.Products
                .ProjectTo<GetAllProductsResponse>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
