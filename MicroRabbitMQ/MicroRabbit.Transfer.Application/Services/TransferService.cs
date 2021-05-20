using MicroRabbit.Transfer.Application.Interface;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus bus;
        public TransferService(ITransferRepository transferRepository,IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            bus = eventBus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
