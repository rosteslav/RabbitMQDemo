namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal ammont)
        {
            From = from; 
            To = to;
            Ammount = ammont;
        }
    }
}
