using ExerciseDemo.Application.Common.Responses;
using ExerciseDemo.Application.DTOs.Products;
using ExerciseDemo.Application.Interfaces;
using ExerciseDemo.Domain.Entities;
using FluentValidation;
using MediatR;
namespace ExerciseDemo.Application.Queries
{
    public class GetHistoryTicketNotokQueryRequest : GetHistoryTicketNotokRequestModel, IRequest<ApiResponse<List<Product>?>>
    {
        public class Validator : FluentValidation.AbstractValidator<GetHistoryTicketNotokQueryRequest>
        {
            public Validator()
            {
                RuleFor(x => x.SupId).GreaterThan(0).LessThan(int.MaxValue);
                RuleFor(x => x.ObjId).GreaterThan(0).LessThan(int.MaxValue);
            }
        }
        public class Handler : IRequestHandler<GetHistoryTicketNotokQueryRequest, ApiResponse<List<Product>?>>
        {
            private readonly IProductRepository productRepository;

            public Handler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }
            public async Task<ApiResponse<List<Product>?>> Handle (GetHistoryTicketNotokQueryRequest request, CancellationToken cancellationToken)
            {
                var histories = await productRepository.GetHistoryNotOk(request.SupId, cancellationToken);
                if (histories == null || histories.Count <= 0)
                {
                    return new ApiResponse<List<Product>?>("Lấy lịch sử ticket Not OK không thành công");
                }
                return new ApiResponse<List<Product>?>(histories);

            }
        }
    }
}
