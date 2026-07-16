using CleanArchitecture.Application.Common.Responses;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;
using MediatR;

namespace CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCarWithPagination;

public sealed record GetAllCarWithPaginationQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PaginationResponse<GetAllCarResponse>>;