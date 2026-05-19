using Kafka.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.Application.IServices
{
    public interface IServiceBcpPartOrder
    {
        Task<int> SaveBcpPartOrderAsync(List<BcpPartOrderDto> bcpPartOrderDtos);
    }
}
