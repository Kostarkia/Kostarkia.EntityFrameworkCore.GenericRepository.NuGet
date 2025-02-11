using System.Threading.Tasks;
using System.Threading;

namespace GenericRepository;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int SaveChanges();
}