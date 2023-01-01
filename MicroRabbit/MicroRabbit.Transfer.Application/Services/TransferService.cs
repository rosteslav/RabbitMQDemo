using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Application.Serives
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository, IEventBus bus) 
        {
            _transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
