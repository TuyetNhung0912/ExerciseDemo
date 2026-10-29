using ExerciseDemo.Application.Common.Responses;
using ExerciseDemo.Application.DTOs.Posts;
using ExerciseDemo.Application.Interfaces;
using MediatR;

namespace ExerciseDemo.Application.Queries
{
    public class GetExternalPostQueryRequest : IRequest<ApiResponse<ExternalPostDto?>>
    {
        public int PostId { get; set; }

        public class Handler: IRequestHandler< GetExternalPostQueryRequest, ApiResponse<ExternalPostDto?>>
        {
            private readonly IJsonPlaceholderService service;

            public Handler(IJsonPlaceholderService service)
            {
                this.service = service;
            }

            public async Task<ApiResponse<ExternalPostDto?>> Handle(GetExternalPostQueryRequest request, CancellationToken cancellationToken)
            {
                var post = await service.GetPostAsync( request.PostId, cancellationToken);

                if (post == null)
                {
                    return new ApiResponse<ExternalPostDto?>("Không tìm thấy bài viết");
                }
                return new ApiResponse<ExternalPostDto?>( post);
            }
        }
    }
}
