namespace CleanArchitecture.Application.Common.Responses;

public sealed record PaginationResponse<T>(IList<T> Items, int PageNumber, int PageSize, int TotalCount, int TotalPages);