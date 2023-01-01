using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransfersController : ControllerBase
    {
        private readonly ILogger<TransfersController> _logger;
        private readonly ITransferService _transferservice;

        public TransfersController(ILogger<TransfersController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferservice = transferService;
        }

        [HttpGet]
        public IEnumerable<TransferLog> Get()
        {
            return _transferservice.GetTransferLogs();
        }
    }
}