﻿using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferTDO trasferDTO);
    }
}
