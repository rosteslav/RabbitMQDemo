namespace MicroRabbit.Banking.Application.Models
{
    public class AmountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
