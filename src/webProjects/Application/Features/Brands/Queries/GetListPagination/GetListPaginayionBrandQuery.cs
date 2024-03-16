using Application.Features.Brands.Models;
using Core.Application.Request;
using MediatR;

namespace Application.Features.Brands.Queries.GetListPagination;

public class GetListPaginayionBrandQuery : IRequest<BrandListModel>
{
    public PageRequest PageRequest { get; set; }
}
