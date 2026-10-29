using ExerciseDemo.Domain.Entities;

namespace ExerciseDemo.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>?> GetHistoryNotOk(int supId, CancellationToken cancellationToken = default);

    }
}
