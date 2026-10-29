using ExerciseDemo.Application.DTOs.Posts;
using ExerciseDemo.Application.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;

namespace ExerciseDemo.Infrastructure.Services
{
    public class JsonPlaceholderService : IJsonPlaceholderService
    {
        private readonly HttpClient httpClient;

        public JsonPlaceholderService(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient(nameof(JsonPlaceholderService));
        }

        public async Task<ExternalPostDto?> GetPostAsync(int postId, CancellationToken cancellationToken)
        {
            using var response = await httpClient.GetAsync($"posts/{postId}",cancellationToken);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ExternalPostDto>(cancellationToken: cancellationToken);
        }
    }
}
