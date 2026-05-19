
using Kafka.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kafka.Infrastructure.Repositories.BcpPartOrder
{
    public class RepositoryBcpPartOrder(ApplicationDbContext applicationDbContext) : IRepositoryBcpPartOrder
    {
        private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

        public async Task<int> SaveBcpPartOrderAsync(List<Domain.Entities.BcpPartOrder> bcpPartOrders)
        {
            await applicationDbContext.BcpPartOrders.AddRangeAsync(bcpPartOrders);

            return await applicationDbContext.SaveChangesAsync();
        }

        public async Task SaveOrUpdateAsync(List<Domain.Entities.BcpPartOrder> entities,   CancellationToken cancellationToken)
        {
            try
            {
                if (entities == null || !entities.Any())
                {
                    return;
                }

                // Remove invalid records
                entities = entities
                    .Where(x =>
                        !string.IsNullOrWhiteSpace(x.BcptaskId))
                    .ToList();

                if (!entities.Any())
                {
                    return;
                }

                // Incoming task ids
                var taskIds = entities
                    .Select(x => x.BcptaskId!.Trim())
                    .Distinct()
                    .ToList();

                // Existing records
                var existingEntities = await applicationDbContext
                    .BcpPartOrders
                    .Where(x =>
                        x.BcptaskId != null &&
                        taskIds.Contains(x.BcptaskId))
                    .ToListAsync(cancellationToken);

                var existingLookup = existingEntities
                    .ToDictionary(
                        x => x.BcptaskId!,
                        StringComparer.OrdinalIgnoreCase);

                foreach (var entity in entities)
                {
                    try
                    {
                        var taskId = entity.BcptaskId!.Trim();

                        // UPDATE
                        if (existingLookup.TryGetValue(
                                taskId,
                                out var existingEntity))
                        {
                            var existingId =
                                existingEntity.Id;

                            applicationDbContext.Entry(existingEntity)
                                .CurrentValues
                                .SetValues(entity);

                            // Preserve PK
                            existingEntity.Id =
                                existingId;

                            existingEntity.UpdatedGmtTimestamp =
                                DateTime.UtcNow;
                        }
                        else
                        {
                            // INSERT
                            // Reset identity column
                            entity.Id = 0;
                            entity.InsertGmtTimestamp =
                                DateTime.UtcNow;

                            await applicationDbContext
                                .BcpPartOrders
                                .AddAsync(
                                    entity,
                                    cancellationToken);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(
                            $"Error processing TaskId {entity.BcptaskId}: {ex.Message}");
                    }
                }

                var affectedRows =
                    await applicationDbContext
                        .SaveChangesAsync(cancellationToken);

                Console.WriteLine(
                    $"SaveChanges successful. Rows affected: {affectedRows}");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(
                    $"Database update error: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine(
                        $"Inner exception: {ex.InnerException.Message}");
                }

                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Unexpected error: {ex.Message}");

                throw;
            }
        }
    }
}
