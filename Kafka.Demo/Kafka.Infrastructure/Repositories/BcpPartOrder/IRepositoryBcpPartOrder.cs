
namespace Kafka.Infrastructure.Repositories
{
    public interface IRepositoryBcpPartOrder
    {
        Task<int> SaveBcpPartOrderAsync(List<Domain.Entities.BcpPartOrder> bcpPartOrders);

        Task SaveOrUpdateAsync(List<Domain.Entities.BcpPartOrder> entities, CancellationToken cancellationToken);
    }
}
