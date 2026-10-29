using ExerciseDemo.Application.DTOs.Posts;
namespace ExerciseDemo.Application.Interfaces
{
    public interface IJsonPlaceholderService
    {
        Task<ExternalPostDto?> GetPostAsync( int postId, CancellationToken cancellationToken = default);
    }
}
