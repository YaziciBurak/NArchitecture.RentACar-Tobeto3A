using Application.Features.Brands.Dtos;
using Application.Features.Cars.Dtos;
using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.Create;

public class CreateModelCommand : IRequest<CreatedModelResponse>
{
    public int BrandId { get; set; }
    public string Name { get; set; }

}
