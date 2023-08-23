using AutoMapper;
using Domain.Models;

namespace Application.Queries
{
    public class GetAllProductsMapper : Profile
    {
        public GetAllProductsMapper()
        {
            CreateMap<Product, GetAllProductsResponse>();
        }
    }
}
