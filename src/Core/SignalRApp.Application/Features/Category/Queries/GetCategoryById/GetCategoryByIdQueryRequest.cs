namespace SignalRApp.Application.Features.Category.Queries.GetCategoryById;

public record GetCategoryByIdQueryRequest(int Id):IQuery<GetCategoryByIdQueryResponse>;