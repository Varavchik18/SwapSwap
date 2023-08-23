using MediatR;

namespace Application.Queries
{
    public class GetAllProductsRequest : IRequest<List<GetAllProductsResponse>>
    {
    }
}
